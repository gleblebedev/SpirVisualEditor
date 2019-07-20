using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpBranch: Instruction
    {
        public OpBranch()
        {
        }

        public override Op OpCode { get { return Op.OpBranch; } }

		public Spv.IdRef TargetLabel { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("TargetLabel", TargetLabel);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    TargetLabel = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {TargetLabel}";
        }
    }
}
