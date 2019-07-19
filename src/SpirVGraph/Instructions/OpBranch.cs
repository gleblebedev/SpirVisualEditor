using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpBranch: Instruction
    {
        public OpBranch()
        {
        }

        public override Op OpCode { get { return Op.OpBranch; } }

		public uint TargetLabel { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    TargetLabel = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {TargetLabel}";
        }
    }
}
