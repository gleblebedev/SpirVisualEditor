using System;

namespace SpirVGraph.Spv
{
    public class FPFastMathMode : ValueEnum
    {
		[Flags]
        public enum Enumerant
        {
            None = 0x0000,
            [Capability(Capability.Enumerant.Kernel)]
            NotNaN = 0x0001,
            [Capability(Capability.Enumerant.Kernel)]
            NotInf = 0x0002,
            [Capability(Capability.Enumerant.Kernel)]
            NSZ = 0x0004,
            [Capability(Capability.Enumerant.Kernel)]
            AllowRecip = 0x0008,
            [Capability(Capability.Enumerant.Kernel)]
            Fast = 0x0010,
		}

        public FPFastMathMode(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static FPFastMathMode Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
			return new FPFastMathMode(id);
        }

        public static FPFastMathMode ParseOptional(WordReader reader, uint wordCount)
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