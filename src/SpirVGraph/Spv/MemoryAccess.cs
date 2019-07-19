using System;
using System.Collections.Generic;

namespace SpirVGraph.Spv
{
    public class MemoryAccess : ValueEnum
    {
		[Flags]
        public enum Enumerant
        {
            None = 0x0000,
            Volatile = 0x0001,
            Aligned = 0x0002,
            Nontemporal = 0x0004,
		}

        public MemoryAccess(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static MemoryAccess Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
			return new MemoryAccess(id);
        }

        public static MemoryAccess ParseOptional(WordReader reader, uint wordCount)
        {
			if (wordCount == 0) return null;
            return Parse(reader, wordCount);
        }

        public static IList<MemoryAccess> ParseCollection(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            var res = new List<MemoryAccess>();
            while (reader.Position < end)
            {
                res.Add(Parse(reader, end-reader.Position));
            }
            return res;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}