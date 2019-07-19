namespace SpirVGraph.Spv
{
    public class ExecutionModel : ValueEnum
    {
        public enum Enumerant
        {
            [Capability(Capability.Enumerant.Shader)]
            Vertex = 0,
            [Capability(Capability.Enumerant.Tessellation)]
            TessellationControl = 1,
            [Capability(Capability.Enumerant.Tessellation)]
            TessellationEvaluation = 2,
            [Capability(Capability.Enumerant.Geometry)]
            Geometry = 3,
            [Capability(Capability.Enumerant.Shader)]
            Fragment = 4,
            [Capability(Capability.Enumerant.Shader)]
            GLCompute = 5,
            [Capability(Capability.Enumerant.Kernel)]
            Kernel = 6,
		}


        public ExecutionModel(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static ExecutionModel Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new ExecutionModel(id);
            }
        }
		
        public static ExecutionModel ParseOptional(WordReader reader, uint wordCount)
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