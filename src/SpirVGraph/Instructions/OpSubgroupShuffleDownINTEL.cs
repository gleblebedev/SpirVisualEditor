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

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    Current = Spv.IdRef.Parse(reader, end-reader.Position);
		    Next = Spv.IdRef.Parse(reader, end-reader.Position);
		    Delta = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Current} {Next} {Delta}";
        }
    }
}
