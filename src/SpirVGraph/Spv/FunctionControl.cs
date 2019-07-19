using System;

namespace SpirVGraph.Spv
{
    public class FunctionControl : ValueEnum
    {
		[Flags]
        public enum Enumerant
        {
            None = 0x0000,
            Inline = 0x0001,
            DontInline = 0x0002,
            Pure = 0x0004,
            Const = 0x0008,
		}

        public FunctionControl(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static FunctionControl Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
			return new FunctionControl(id);
        }

        public static FunctionControl ParseOptional(WordReader reader, uint wordCount)
        {
			if (wordCount == 0) return null;
            return Parse(reader, wordCount);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}