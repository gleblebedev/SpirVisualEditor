using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpControlBarrier: Instruction
    {
        public OpControlBarrier()
        {
        }

        public override Op OpCode { get { return Op.OpControlBarrier; } }

		public uint Execution { get; set; }
		public uint Memory { get; set; }
		public uint Semantics { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Execution = ParseWord(reader, end-reader.Position);
		    Memory = ParseWord(reader, end-reader.Position);
		    Semantics = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Execution} {Memory} {Semantics}";
        }
    }
}
