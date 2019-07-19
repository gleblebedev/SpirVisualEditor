namespace SpirVGraph.Spv
{
    public class SourceLanguage : ValueEnum
    {
        public enum Enumerant
        {
            Unknown = 0,
            ESSL = 1,
            GLSL = 2,
            OpenCL_C = 3,
            OpenCL_CPP = 4,
            HLSL = 5,
		}


        public SourceLanguage(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static SourceLanguage Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new SourceLanguage(id);
            }
        }
		
        public static SourceLanguage ParseOptional(WordReader reader, uint wordCount)
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