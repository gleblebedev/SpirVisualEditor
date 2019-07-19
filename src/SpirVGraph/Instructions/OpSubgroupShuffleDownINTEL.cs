using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSubgroupShuffleDownINTEL: Instruction
    {
        public OpSubgroupShuffleDownINTEL()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupShuffleDownINTEL; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Current { get; set; }
		public uint Next { get; set; }
		public uint Delta { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Current = ParseWord(reader, end-reader.Position);
		    Next = ParseWord(reader, end-reader.Position);
		    Delta = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Current} {Next} {Delta}";
        }
    }
}
