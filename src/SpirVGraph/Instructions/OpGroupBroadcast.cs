using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupBroadcast: Instruction
    {
        public OpGroupBroadcast()
        {
        }

        public override Op OpCode { get { return Op.OpGroupBroadcast; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Execution { get; set; }
		public uint Value { get; set; }
		public uint LocalId { get; set; }

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
		    Execution = Spv.IdScope.Parse(reader, end-reader.Position);
		    Value = Spv.IdRef.Parse(reader, end-reader.Position);
		    LocalId = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Execution} {Value} {LocalId}";
        }
    }
}
