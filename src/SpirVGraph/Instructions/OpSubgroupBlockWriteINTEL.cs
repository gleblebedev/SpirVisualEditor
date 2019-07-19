using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSubgroupBlockWriteINTEL: Instruction
    {
        public OpSubgroupBlockWriteINTEL()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupBlockWriteINTEL; } }

		public uint Ptr { get; set; }
		public uint Data { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Ptr = Spv.IdRef.Parse(reader, end-reader.Position);
		    Data = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Ptr} {Data}";
        }
    }
}
