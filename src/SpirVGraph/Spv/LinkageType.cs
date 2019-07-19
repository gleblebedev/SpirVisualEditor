namespace SpirVGraph.Spv
{
    public class LinkageType : ValueEnum
    {
        public enum Enumerant
        {
            [Capability(Capability.Enumerant.Linkage)]
            Export = 0,
            [Capability(Capability.Enumerant.Linkage)]
            Import = 1,
		}


        public LinkageType(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static LinkageType Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new LinkageType(id);
            }
        }
		
        public static LinkageType ParseOptional(WordReader reader, uint wordCount)
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