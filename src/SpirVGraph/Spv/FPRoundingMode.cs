namespace SpirVGraph.Spv
{
    public class FPRoundingMode : ValueEnum
    {
        public enum Enumerant
        {
            [Capability(Capability.Enumerant.Kernel)]
            [Capability(Capability.Enumerant.StorageUniformBufferBlock16)]
            [Capability(Capability.Enumerant.StorageUniform16)]
            [Capability(Capability.Enumerant.StoragePushConstant16)]
            [Capability(Capability.Enumerant.StorageInputOutput16)]
            RTE = 0,
            [Capability(Capability.Enumerant.Kernel)]
            [Capability(Capability.Enumerant.StorageUniformBufferBlock16)]
            [Capability(Capability.Enumerant.StorageUniform16)]
            [Capability(Capability.Enumerant.StoragePushConstant16)]
            [Capability(Capability.Enumerant.StorageInputOutput16)]
            RTZ = 1,
            [Capability(Capability.Enumerant.Kernel)]
            [Capability(Capability.Enumerant.StorageUniformBufferBlock16)]
            [Capability(Capability.Enumerant.StorageUniform16)]
            [Capability(Capability.Enumerant.StoragePushConstant16)]
            [Capability(Capability.Enumerant.StorageInputOutput16)]
            RTP = 2,
            [Capability(Capability.Enumerant.Kernel)]
            [Capability(Capability.Enumerant.StorageUniformBufferBlock16)]
            [Capability(Capability.Enumerant.StorageUniform16)]
            [Capability(Capability.Enumerant.StoragePushConstant16)]
            [Capability(Capability.Enumerant.StorageInputOutput16)]
            RTN = 3,
		}


        public FPRoundingMode(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static FPRoundingMode Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
            switch (id)
            {
                default:
                    return new FPRoundingMode(id);
            }
        }
		
        public static FPRoundingMode ParseOptional(WordReader reader, uint wordCount)
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