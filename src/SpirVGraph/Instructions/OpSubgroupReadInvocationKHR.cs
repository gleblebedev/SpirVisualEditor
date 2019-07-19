using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSubgroupReadInvocationKHR: Instruction
    {
        public OpSubgroupReadInvocationKHR()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupReadInvocationKHR; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Value { get; set; }
		public uint Index { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Value = ParseWord(reader, end-reader.Position);
		    Index = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Value} {Index}";
        }
    }
}
