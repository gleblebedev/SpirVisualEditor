using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeEvent: Instruction
    {
        public OpTypeEvent()
        {
        }

        public override Op OpCode { get { return Op.OpTypeEvent; } }

		public uint IdResult { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} ";
        }
    }
}
