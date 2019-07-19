using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupWaitEvents: Instruction
    {
        public OpGroupWaitEvents()
        {
        }

        public override Op OpCode { get { return Op.OpGroupWaitEvents; } }

		public uint Execution { get; set; }
		public uint NumEvents { get; set; }
		public uint EventsList { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Execution = ParseWord(reader, end-reader.Position);
		    NumEvents = ParseWord(reader, end-reader.Position);
		    EventsList = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Execution} {NumEvents} {EventsList}";
        }
    }
}
