using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupMemberDecorate: Instruction
    {
        public OpGroupMemberDecorate()
        {
        }

        public override Op OpCode { get { return Op.OpGroupMemberDecorate; } }

		public uint DecorationGroup { get; set; }
		public IList<IdAndLiteral> Targets { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    DecorationGroup = ParseWord(reader, end-reader.Position);
		    Targets = ParsePairIdRefLiteralIntegerCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {DecorationGroup} {Targets}";
        }
    }
}
