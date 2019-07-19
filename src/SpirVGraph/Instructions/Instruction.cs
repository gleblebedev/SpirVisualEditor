using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public abstract  class Instruction
    {
        public abstract Op OpCode { get; }

        public virtual void Parse(WordReader reader, uint wordCount)
        {
            for (uint i = 1; i < wordCount; ++i)
            {
                reader.ReadWord();
            }
        }

        public string ParseString(WordReader reader, uint wordCount)
        {
            if (wordCount == 0)
                return null;
            return reader.ReadString();
        }

        public uint ParseWord(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }
        public IList<IdAndLiteral> ParsePairLiteralIntegerIdRefCollection(WordReader reader, uint wordCount)
        {
            var res = new List<IdAndLiteral>();
            for (uint i = 0; i != wordCount; i+=2)
            {
                var literal = reader.ReadWord();
                var id = reader.ReadWord();
                res.Add(new IdAndLiteral(id, literal));
            }
            return res;
        }
        public IList<IdAndLiteral> ParsePairIdRefLiteralIntegerCollection(WordReader reader, uint wordCount)
        {
            var res = new List<IdAndLiteral>();
            for (uint i = 0; i != wordCount; i += 2)
            {
                var id = reader.ReadWord();
                var literal = reader.ReadWord();
                res.Add(new IdAndLiteral(id, literal));
            }
            return res;
        }
        public IList<uint> ParseWordCollection(WordReader reader, uint wordCount)
        {
            var res = new List<uint>();
            for (uint i = 0; i != wordCount; ++i)
            {
                res.Add(reader.ReadWord());
            }
            return res;
        }
        public uint? ParseOptionalWord(WordReader reader, uint wordCount)
        {
            if (wordCount > 0)
            {
                return reader.ReadWord();
            }

            return null;
        }

        public override string ToString()
        {
            return OpCode.ToString();
        }
    }
}