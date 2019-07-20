using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpBuildNDRange: InstructionWithId
    {
        public OpBuildNDRange()
        {
        }

        public override Op OpCode { get { return Op.OpBuildNDRange; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef GlobalWorkSize { get; set; }
		public Spv.IdRef LocalWorkSize { get; set; }
		public Spv.IdRef GlobalWorkOffset { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("GlobalWorkSize", GlobalWorkSize);
		    yield return new ReferenceProperty("LocalWorkSize", LocalWorkSize);
		    yield return new ReferenceProperty("GlobalWorkOffset", GlobalWorkOffset);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    GlobalWorkSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    LocalWorkSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    GlobalWorkOffset = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {GlobalWorkSize} {LocalWorkSize} {GlobalWorkOffset}";
        }
    }
}
