using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSubgroupShuffleUpINTEL: Instruction
    {
        public OpSubgroupShuffleUpINTEL()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupShuffleUpINTEL; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Previous { get; set; }
		public uint Current { get; set; }
		public uint Delta { get; set; }

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
		    Previous = ParseWord(reader, end-reader.Position);
		    Current = ParseWord(reader, end-reader.Position);
		    Delta = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Previous} {Current} {Delta}";
        }
    }
}
