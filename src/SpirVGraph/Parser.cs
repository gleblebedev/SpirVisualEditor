using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Toe.Scripting;

namespace SpirVGraph
{
    internal class Parser
    {
        private readonly BinaryReader _reader;
        private readonly int _spirvwords;
        private int _position;
        private Script _script;
        private uint _bound;

        private Instruction[] _instructions;

        public Parser(BinaryReader reader, int spirvwords)
        {
            _reader = reader;
            _spirvwords = spirvwords;
            _script = new Script();
        }

        public Script Parse()
        {
            ParseMagic();
            ParseVersion();
            ParseGeneratorName();
            ParseBound();
            ParseZero();

            while (_position < _spirvwords)
            {
                ParseOperand();
            }

            return _script;
        }

        public uint ReadWord()
        {
            ++_position;
            return _reader.ReadUInt32();
        }
        public string ReadString(uint words)
        {
            var bytes =_reader.ReadBytes((int) words * 4);
            var len = bytes.Length;
            while (len > 0 && bytes[len-1] == 0)
            {
                --len;
            }
            _position += bytes.Length/4;
            if (len == 0)
                return string.Empty;
            return Encoding.UTF8.GetString(bytes,0,len);
        }
        public string ReadString()
        {
            var bytes = new List<byte>(4);
            for(;;)
            {
                byte last;
                bytes.Add((byte)_reader.ReadByte());
                bytes.Add((byte)_reader.ReadByte());
                bytes.Add((byte)_reader.ReadByte());
                bytes.Add(last=(byte)_reader.ReadByte());
                ++_position;
                if (last == 0)
                    break;

            }
            var len = bytes.Count;
            while (len > 0 && bytes[len - 1] == 0)
            {
                --len;
            }
            if (len == 0)
                return string.Empty;
            return Encoding.UTF8.GetString(bytes.ToArray(), 0, len);
        }
        private void ParseOperand()
        {
            var cmd = ReadWord();
            var op = (SpvOp)(cmd & 0x0FFFF);
            var wordCount = ((cmd>>16) & 0x0FFFF);
            var end = _position + wordCount - 1;
            switch (op)
            {
                case SpvOp.Capability:
                    ParseCapability(op, wordCount);
                    break;
                case SpvOp.ExtInstImport:
                    ParseExtInstImport(op, wordCount);
                    break;
                case SpvOp.MemoryModel:
                    ParseMemoryModel(op, wordCount);
                    break;
                case SpvOp.EntryPoint:
                    ParseEntryPoint(op, wordCount);
                    break;
                case SpvOp.ExecutionMode:
                    ParseExecutionMode(op, wordCount);
                    break;
                case SpvOp.Source:
                    ParseSource(op, wordCount);
                    break;
                case SpvOp.Name:
                    ParseName(op, wordCount);
                    break;
                case SpvOp.Decorate:
                    ParseDecorate(op, wordCount);
                    break;
                case SpvOp.FunctionEnd:
                    ParseFunctionEnd(op, wordCount);
                    break;
                default:
                    Debug.WriteLine("Unknown operand: "+op);
                    for (int i = 1; i < wordCount; ++i)
                    {
                        ReadWord();
                    }
                    break;
            }

            if (end != _position)
            {
                throw new Exception("Bug in SpirV parser. Location doesn't match next operation location.");
            }
        }

        private void ParseSource(SpvOp op, uint wordCount)
        {
            AssertMinWordCount(op, 3, wordCount);
            var end = _position + wordCount - 1;
            var sourceLanguage = (SpvSourceLanguage)ReadWord();
            var version = ReadWord();
            if (_position < end)
            {
                var file = ReadWord();
            }
            if (_position < end)
            {
                var source = ReadString();
            }
            Debug.WriteLine($"{op}: {sourceLanguage}, {version}");
        }
        private void ParseFunctionEnd(SpvOp op, uint wordCount)
        {
            AssertWordCount(op, 1, wordCount);
            Debug.WriteLine($"{op}");
        }
        private void ParseName(SpvOp op, uint wordCount)
        {
            AssertMinWordCount(op, 3, wordCount);
            var id = ReadWord();
            if (_instructions[id] == null)
            {
                _instructions[id] = new Instruction(SpvOp.Name);
            }
            var name = ReadString(wordCount-2);
            _instructions[id].Name = name;
            Debug.WriteLine($"{op}: {id}, {name}");
        }

        private void ParseDecorate(SpvOp op, uint wordCount)
        {
            AssertMinWordCount(op, 3, wordCount);
            var end = _position + wordCount - 1;
            var id = ReadWord();
            while (_position != end)
            {
                ReadWord();
            }
            Debug.WriteLine($"{op}: {id}");
        }

        private void ParseExecutionMode(SpvOp op, uint wordCount)
        {
            AssertMinWordCount(op, 3, wordCount);
            var end = _position + wordCount - 1;
            var entryPoint = ReadWord();
            var executionMode = (SpvExecutionMode)ReadWord();
            if (_position < end)
            {
                var source = ReadString();
            }
            Debug.WriteLine($"{op}: {entryPoint}, {executionMode}");
        }

        private void ParseEntryPoint(SpvOp op, uint wordCount)
        {
            AssertMinWordCount(op, 4, wordCount);
            var end = _position + wordCount - 1;
            var executionModel = (SpvExecutionModel)ReadWord();
            var id = ReadWord();
            var instruction = new Instruction(SpvOp.EntryPoint);
            _instructions[id] = instruction;
            var name = ReadString();
            instruction.Name = name;
            var interfaces = new List<uint>();
            while (_position < end)
            {
                interfaces.Add(ReadWord());
            }
            Debug.WriteLine($"{op}: {executionModel}, {id}, {name}, {string.Join(", ", interfaces)}");
        }

        private void ParseMemoryModel(SpvOp op, uint wordCount)
        {
            AssertWordCount(op, 3, wordCount);
            var addressing = (SpvAddressingModel)ReadWord();
            var memory = (SpvMemoryModel)ReadWord();
            Debug.WriteLine(op + ": " + addressing+", "+ memory);
        }

        private void ParseExtInstImport(SpvOp op, uint wordCount)
        {
            AssertMinWordCount(op, 3, wordCount);
            var label = ReadWord();
            Debug.WriteLine(op + ": " + ReadString(wordCount - 2));
        }

        private void ParseCapability(SpvOp op, uint wordCount)
        {
            AssertWordCount(op, 2, wordCount);
            _capabilities.Add((SpvCapability) ReadWord());
        }

        private void AssertWordCount(SpvOp op, uint expected, uint actual)
        {
            if (expected != actual)
            {
                throw new FormatException($"Word count {actual} doesn't match expected {expected} for operation {op}");
            }
        }
        private void AssertMinWordCount(SpvOp op, uint expected, uint actual)
        {
            if (expected > actual)
            {
                throw new FormatException($"Word count {actual} should be at least {expected} for operation {op}");
            }
        }

        List<SpvCapability> _capabilities = new List<SpvCapability>();

        private void ParseGeneratorName()
        {
            ReadWord(); //Skip generator name
        }
        private void ParseBound()
        {
            _bound  = ReadWord();
            _instructions = new Instruction[_bound];
        }
        private void ParseZero()
        {
            if (ReadWord() != 0)
            {
                throw new FormatException("SpirV reserved word isn't 0");
            }
        }
        private void ParseVersion()
        {
            if (ReadWord()!= 0x00010000)
            {
                throw new FormatException("Unsupported SpirV version");
            }
        }

        private void ParseMagic()
        {
            if (ReadWord() != 0x07230203)
            {
                throw new FormatException("SpirV magic number doesn't match");
            }
        }
    }
}