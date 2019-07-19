using System;
using System.Collections.Generic;

namespace SpirVGraph.Spv
{
    public class SelectionControl : ValueEnum
    {
		[Flags]
        public enum Enumerant
        {
            None = 0x0000,
            Flatten = 0x0001,
            DontFlatten = 0x0002,
		}

        public SelectionControl(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static SelectionControl Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
			return new SelectionControl(id);
        }

        public static SelectionControl ParseOptional(WordReader reader, uint wordCount)
        {
			if (wordCount == 0) return null;
            return Parse(reader, wordCount);
        }

        public static IList<SelectionControl> ParseCollection(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            var res = new List<SelectionControl>();
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