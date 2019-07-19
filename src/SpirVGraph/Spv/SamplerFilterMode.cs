namespace SpirVGraph.Spv
{
    public class SamplerFilterMode : ValueEnum
    {
        public enum Enumerant
        {
            [Capability(Capability.Enumerant.Kernel)]
            Nearest = 0,
            [Capability(Capability.Enumerant.Kernel)]
            Linear = 1,
		}


        public SamplerFilterMode(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static SamplerFilterMode Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new SamplerFilterMode(id);
            }
        }
		
        public static SamplerFilterMode ParseOptional(WordReader reader, uint wordCount)
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