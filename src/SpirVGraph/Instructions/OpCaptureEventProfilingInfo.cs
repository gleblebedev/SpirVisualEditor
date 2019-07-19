using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpCaptureEventProfilingInfo: Instruction
    {
        public OpCaptureEventProfilingInfo()
        {
        }

        public override Op OpCode { get { return Op.OpCaptureEventProfilingInfo; } }

		public uint Event { get; set; }
		public uint ProfilingInfo { get; set; }
		public uint Value { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Event = ParseWord(reader, end-reader.Position);
		    ProfilingInfo = ParseWord(reader, end-reader.Position);
		    Value = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Event} {ProfilingInfo} {Value}";
        }
    }
}
