using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpEnqueueMarker: Instruction
    {
        public OpEnqueueMarker()
        {
        }

        public override Op OpCode { get { return Op.OpEnqueueMarker; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Queue { get; set; }
		public uint NumEvents { get; set; }
		public uint WaitEvents { get; set; }
		public uint RetEvent { get; set; }

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
		    Queue = Spv.IdRef.Parse(reader, end-reader.Position);
		    NumEvents = Spv.IdRef.Parse(reader, end-reader.Position);
		    WaitEvents = Spv.IdRef.Parse(reader, end-reader.Position);
		    RetEvent = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Queue} {NumEvents} {WaitEvents} {RetEvent}";
        }
    }
}
