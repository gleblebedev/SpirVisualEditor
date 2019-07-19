using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSubgroupShuffleXorINTEL: Instruction
    {
        public OpSubgroupShuffleXorINTEL()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupShuffleXorINTEL; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Data { get; set; }
		public uint Value { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Data = ParseWord(reader, end-reader.Position);
		    Value = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Data} {Value}";
        }
    }
}
