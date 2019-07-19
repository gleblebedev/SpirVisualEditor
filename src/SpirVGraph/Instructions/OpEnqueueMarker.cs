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

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Queue = ParseWord(reader, end-reader.Position);
		    NumEvents = ParseWord(reader, end-reader.Position);
		    WaitEvents = ParseWord(reader, end-reader.Position);
		    RetEvent = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Queue} {NumEvents} {WaitEvents} {RetEvent}";
        }
    }
}
