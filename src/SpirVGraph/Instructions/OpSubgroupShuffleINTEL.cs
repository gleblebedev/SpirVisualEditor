using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSubgroupShuffleINTEL: Instruction
    {
        public OpSubgroupShuffleINTEL()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupShuffleINTEL; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Data { get; set; }
		public uint InvocationId { get; set; }

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
		    Data = Spv.IdRef.Parse(reader, end-reader.Position);
		    InvocationId = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Data} {InvocationId}";
        }
    }
}
