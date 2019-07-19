using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpEndStreamPrimitive: Instruction
    {
        public OpEndStreamPrimitive()
        {
        }

        public override Op OpCode { get { return Op.OpEndStreamPrimitive; } }

		public uint Stream { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Stream = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Stream}";
        }
    }
}
