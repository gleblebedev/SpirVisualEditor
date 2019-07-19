namespace SpirVGraph.Spv
{
    public class SamplerAddressingMode : ValueEnum
    {
        public enum Enumerant
        {
            [Capability(Capability.Enumerant.Kernel)]
            None = 0,
            [Capability(Capability.Enumerant.Kernel)]
            ClampToEdge = 1,
            [Capability(Capability.Enumerant.Kernel)]
            Clamp = 2,
            [Capability(Capability.Enumerant.Kernel)]
            Repeat = 3,
            [Capability(Capability.Enumerant.Kernel)]
            RepeatMirrored = 4,
		}


        public SamplerAddressingMode(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static SamplerAddressingMode Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new SamplerAddressingMode(id);
            }
        }
		
        public static SamplerAddressingMode ParseOptional(WordReader reader, uint wordCount)
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