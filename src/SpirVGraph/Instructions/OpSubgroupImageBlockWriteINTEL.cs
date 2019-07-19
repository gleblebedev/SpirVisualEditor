using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSubgroupImageBlockWriteINTEL: Instruction
    {
        public OpSubgroupImageBlockWriteINTEL()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupImageBlockWriteINTEL; } }

		public uint Image { get; set; }
		public uint Coordinate { get; set; }
		public uint Data { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Image = ParseWord(reader, end-reader.Position);
		    Coordinate = ParseWord(reader, end-reader.Position);
		    Data = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Image} {Coordinate} {Data}";
        }
    }
}
