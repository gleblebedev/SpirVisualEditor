using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SpirVGraph
{
    public class WordReader
    {
        private readonly BinaryReader _reader;
        private readonly InstructionRegistry _instructionRegistry;


        private uint _position = 0;

        public WordReader(BinaryReader reader, InstructionRegistry instructionRegistry)
        {
            _reader = reader;
            _instructionRegistry = instructionRegistry;
        }

        public uint Position
        {
            get { return _position; }
        }

        public InstructionRegistry Instructions
        {
            get { return _instructionRegistry; }
        }

        public uint ReadWord()
        {
            ++_position;
            return _reader.ReadUInt32();
        }

        public string ReadString(uint words)
        {
            var bytes = _reader.ReadBytes((int)words * 4);
            var len = bytes.Length;
            while (len > 0 && bytes[len - 1] == 0) --len;
            _position += (uint)(bytes.Length / 4);
            if (len == 0)
                return string.Empty;
            return Encoding.UTF8.GetString(bytes, 0, len);
        }

        public string ReadString()
        {
            var bytes = new List<byte>(4);
            for (; ; )
            {
                byte last;
                bytes.Add(_reader.ReadByte());
                bytes.Add(_reader.ReadByte());
                bytes.Add(_reader.ReadByte());
                bytes.Add(last = _reader.ReadByte());
                ++_position;
                if (last == 0)
                    break;
            }

            var len = bytes.Count;
            while (len > 0 && bytes[len - 1] == 0) --len;
            if (len == 0)
                return string.Empty;
            return Encoding.UTF8.GetString(bytes.ToArray(), 0, len);
        }

        public byte[] ReadBytes(uint numWords)
        {
            var res = _reader.ReadBytes((int)numWords * 4);
            _position += (uint)res.Length / 4;
            return res;
        }


    }
}