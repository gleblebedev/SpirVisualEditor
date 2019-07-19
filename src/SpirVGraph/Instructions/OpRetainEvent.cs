using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpRetainEvent: Instruction
    {
        public OpRetainEvent()
        {
        }

        public override Op OpCode { get { return Op.OpRetainEvent; } }

		public uint Event { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Event = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Event}";
        }
    }
}
