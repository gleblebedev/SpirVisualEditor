namespace SpirVGraph.Spv
{
    public class AccessQualifier : ValueEnum
    {
        public enum Enumerant
        {
            [Capability(Capability.Enumerant.Kernel)]
            ReadOnly = 0,
            [Capability(Capability.Enumerant.Kernel)]
            WriteOnly = 1,
            [Capability(Capability.Enumerant.Kernel)]
            ReadWrite = 2,
		}


        public AccessQualifier(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static AccessQualifier Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new AccessQualifier(id);
            }
        }
		
        public static AccessQualifier ParseOptional(WordReader reader, uint wordCount)
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