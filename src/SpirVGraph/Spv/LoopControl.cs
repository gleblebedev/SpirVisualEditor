using System;

namespace SpirVGraph.Spv
{
    public class LoopControl : ValueEnum
    {
		[Flags]
        public enum Enumerant
        {
            None = 0x0000,
            Unroll = 0x0001,
            DontUnroll = 0x0002,
		}

        public LoopControl(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static LoopControl Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
			return new LoopControl(id);
        }

        public static LoopControl ParseOptional(WordReader reader, uint wordCount)
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