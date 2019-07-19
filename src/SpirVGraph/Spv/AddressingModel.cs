namespace SpirVGraph.Spv
{
    public class AddressingModel : ValueEnum
    {
        public enum Enumerant
        {
            Logical = 0,
            [Capability(Capability.Enumerant.Addresses)]
            Physical32 = 1,
            [Capability(Capability.Enumerant.Addresses)]
            Physical64 = 2,
		}


        public AddressingModel(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static AddressingModel Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new AddressingModel(id);
            }
        }
		
        public static AddressingModel ParseOptional(WordReader reader, uint wordCount)
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