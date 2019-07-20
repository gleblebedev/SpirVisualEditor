using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpImageSparseSampleProjImplicitLod: InstructionWithId
    {
        public OpImageSparseSampleProjImplicitLod()
        {
        }

        public override Op OpCode { get { return Op.OpImageSparseSampleProjImplicitLod; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef SampledImage { get; set; }
		public Spv.IdRef Coordinate { get; set; }
		public Spv.ImageOperands ImageOperands { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("SampledImage", SampledImage);
		    yield return new ReferenceProperty("Coordinate", Coordinate);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    SampledImage = Spv.IdRef.Parse(reader, end-reader.Position);
		    Coordinate = Spv.IdRef.Parse(reader, end-reader.Position);
		    ImageOperands = Spv.ImageOperands.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {SampledImage} {Coordinate} {ImageOperands}";
        }
    }
}
