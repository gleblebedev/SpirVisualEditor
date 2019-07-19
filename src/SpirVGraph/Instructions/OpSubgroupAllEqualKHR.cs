using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSubgroupAllEqualKHR: Instruction
    {
        public OpSubgroupAllEqualKHR()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupAllEqualKHR; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Predicate { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Predicate = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Predicate}";
        }
    }
}
