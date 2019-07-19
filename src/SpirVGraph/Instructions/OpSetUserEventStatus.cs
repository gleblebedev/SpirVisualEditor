using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSetUserEventStatus: Instruction
    {
        public OpSetUserEventStatus()
        {
        }

        public override Op OpCode { get { return Op.OpSetUserEventStatus; } }

		public uint Event { get; set; }
		public uint Status { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Event = Spv.IdRef.Parse(reader, end-reader.Position);
		    Status = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Event} {Status}";
        }
    }
}
