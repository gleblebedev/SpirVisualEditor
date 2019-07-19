using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpEmitStreamVertex: Instruction
    {
        public OpEmitStreamVertex()
        {
        }

        public override Op OpCode { get { return Op.OpEmitStreamVertex; } }

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
