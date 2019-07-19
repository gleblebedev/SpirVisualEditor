using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpBranchConditional: Instruction
    {
        public OpBranchConditional()
        {
        }

        public override Op OpCode { get { return Op.OpBranchConditional; } }

		public uint Condition { get; set; }
		public uint TrueLabel { get; set; }
		public uint FalseLabel { get; set; }
		public IList<uint> Branchweights { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Condition = ParseWord(reader, end-reader.Position);
		    TrueLabel = ParseWord(reader, end-reader.Position);
		    FalseLabel = ParseWord(reader, end-reader.Position);
		    Branchweights = ParseWordCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Condition} {TrueLabel} {FalseLabel} {Branchweights}";
        }
    }
}
