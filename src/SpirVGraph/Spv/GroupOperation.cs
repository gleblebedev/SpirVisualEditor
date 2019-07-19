namespace SpirVGraph.Spv
{
    public class GroupOperation : ValueEnum
    {
        public enum Enumerant
        {
            [Capability(Capability.Enumerant.Kernel)]
            Reduce = 0,
            [Capability(Capability.Enumerant.Kernel)]
            InclusiveScan = 1,
            [Capability(Capability.Enumerant.Kernel)]
            ExclusiveScan = 2,
		}


        public GroupOperation(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static GroupOperation Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new GroupOperation(id);
            }
        }
		
        public static GroupOperation ParseOptional(WordReader reader, uint wordCount)
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