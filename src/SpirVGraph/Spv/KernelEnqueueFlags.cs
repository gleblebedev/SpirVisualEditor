namespace SpirVGraph.Spv
{
    public class KernelEnqueueFlags : ValueEnum
    {
        public enum Enumerant
        {
            [Capability(Capability.Enumerant.Kernel)]
            NoWait = 0,
            [Capability(Capability.Enumerant.Kernel)]
            WaitKernel = 1,
            [Capability(Capability.Enumerant.Kernel)]
            WaitWorkGroup = 2,
		}


        public KernelEnqueueFlags(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static KernelEnqueueFlags Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new KernelEnqueueFlags(id);
            }
        }
		
        public static KernelEnqueueFlags ParseOptional(WordReader reader, uint wordCount)
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