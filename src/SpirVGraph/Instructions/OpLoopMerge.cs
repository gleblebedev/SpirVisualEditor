using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpLoopMerge: Instruction
    {
        public OpLoopMerge()
        {
        }

        public override Op OpCode { get { return Op.OpLoopMerge; } }

		public uint MergeBlock { get; set; }
		public uint ContinueTarget { get; set; }
		public Spv.LoopControl LoopControl { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
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
