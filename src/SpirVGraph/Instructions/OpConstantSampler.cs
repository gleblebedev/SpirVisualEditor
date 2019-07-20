using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpConstantSampler: InstructionWithId
    {
        public OpConstantSampler()
        {
        }

        public override Op OpCode { get { return Op.OpConstantSampler; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.SamplerAddressingMode SamplerAddressingMode { get; set; }
		public uint Param { get; set; }
		public Spv.SamplerFilterMode SamplerFilterMode { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    SamplerAddressingMode = Spv.SamplerAddressingMode.Parse(reader, end-reader.Position);
		    Param = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    SamplerFilterMode = Spv.SamplerFilterMode.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {SamplerAddressingMode} {Param} {SamplerFilterMode}";
        }
    }
}
