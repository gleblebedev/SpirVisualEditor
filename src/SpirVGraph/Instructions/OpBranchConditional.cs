using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpBranchConditional: Instruction
    {
        public OpBranchConditional()
        {
        }

        public override Op OpCode { get { return Op.OpBranchConditional; } }

		public Spv.IdRef Condition { get; set; }
		public Spv.IdRef TrueLabel { get; set; }
		public Spv.IdRef FalseLabel { get; set; }
		public IList<uint> Branchweights { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Condition", Condition);
		    yield return new ReferenceProperty("TrueLabel", TrueLabel);
		    yield return new ReferenceProperty("FalseLabel", FalseLabel);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Condition = Spv.IdRef.Parse(reader, end-reader.Position);
		    TrueLabel = Spv.IdRef.Parse(reader, end-reader.Position);
		    FalseLabel = Spv.IdRef.Parse(reader, end-reader.Position);
		    Branchweights = Spv.LiteralInteger.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Condition} {TrueLabel} {FalseLabel} {Branchweights}";
        }
    }
}
