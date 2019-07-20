using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpLoopMerge: Instruction
    {
        public OpLoopMerge()
        {
        }

        public override Op OpCode { get { return Op.OpLoopMerge; } }

		public Spv.IdRef MergeBlock { get; set; }
		public Spv.IdRef ContinueTarget { get; set; }
		public Spv.LoopControl LoopControl { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("MergeBlock", MergeBlock);
		    yield return new ReferenceProperty("ContinueTarget", ContinueTarget);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    MergeBlock = Spv.IdRef.Parse(reader, end-reader.Position);
		    ContinueTarget = Spv.IdRef.Parse(reader, end-reader.Position);
		    LoopControl = Spv.LoopControl.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {MergeBlock} {ContinueTarget} {LoopControl}";
        }
    }
}
