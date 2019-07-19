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
		    Value = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Data} {Value}";
        }
    }
}
