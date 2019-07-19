using System;
using System.Collections.Generic;
using System.IO;
using SpirVGraph.Instructions;

namespace SpirVGraph
{
    public class Shader
    {
        private uint _version;
        private uint _generatorName;
        private uint _bound;
        private IList<Instruction> _instructions = new List<Instruction>();

        public static Shader Parse(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            var shader = new Shader();
            if (reader.ReadWord() != 0x07230203) throw new FormatException("SpirV magic number doesn't match");
            shader.Version = reader.ReadWord();
            if (shader.Version != 0x00010000) throw new FormatException("Unsupported SpirV version");
            shader.GeneratorName = reader.ReadWord();
            shader.Bound = reader.ReadWord();
            if (reader.ReadWord() != 0) throw new FormatException("SpirV reserved word isn't 0");
            while (reader.Position < end)
            {
                var instruction = InstructionFactory.Parse(reader);
                shader.Instructions.Add(instruction);
            }
            return shader;
        }

        public uint Bound
        {
            get { return _bound; }
            set { _bound = value; }
        }
        public IList<Instruction> Instructions
        {
            get { return _instructions; }
        }
        public uint GeneratorName
        {
            get { return _generatorName; }
            set { _generatorName = value; }
        }

        public uint Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public static Shader Parse(BinaryReader reader, uint wordCount)
        {
            return Parse(new WordReader(reader), wordCount);
        }
        public static Shader Parse(BinaryReader reader)
        {
            var length = reader.BaseStream.Length - reader.BaseStream.Position;
            if (length % 4 != 0) throw new FormatException("SpirV bytecode length should be divisable by 4");
            return Parse(new WordReader(reader), (uint)length/4);
        }
        public static Shader Parse(byte[] spirVBytes)
        {
            if (spirVBytes.Length % 4 != 0) throw new FormatException("SpirV bytecode length should be divisable by 4");
            using (var binaryReader = new BinaryReader(new MemoryStream(spirVBytes)))
            {
                return Parse(binaryReader, (uint)spirVBytes.Length / 4);
            }
        }
    }
}