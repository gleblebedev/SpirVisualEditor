using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpLifetimeStart: Instruction
    {
        public OpLifetimeStart()
        {
        }

        public override Op OpCode { get { return Op.OpLifetimeStart; } }

		public uint Pointer { get; set; }
		public uint Size { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Pointer = ParseWord(reader, end-reader.Position);
		    Size = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Pointer} {Size}";
        }
    }
}
