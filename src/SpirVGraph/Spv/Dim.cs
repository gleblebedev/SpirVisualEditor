namespace SpirVGraph.Spv
{
    public class Dim : ValueEnum
    {
        public enum Enumerant
        {
            [Capability(Capability.Enumerant.Sampled1D)]
            Dim1D = 0,
            Dim2D = 1,
            Dim3D = 2,
            [Capability(Capability.Enumerant.Shader)]
            Cube = 3,
            [Capability(Capability.Enumerant.SampledRect)]
            Rect = 4,
            [Capability(Capability.Enumerant.SampledBuffer)]
            Buffer = 5,
            [Capability(Capability.Enumerant.InputAttachment)]
            SubpassData = 6,
		}


        public Dim(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static Dim Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new Dim(id);
            }
        }
		
        public static Dim ParseOptional(WordReader reader, uint wordCount)
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