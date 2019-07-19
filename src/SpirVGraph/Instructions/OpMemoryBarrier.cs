using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpMemoryBarrier: Instruction
    {
        public OpMemoryBarrier()
        {
        }

        public override Op OpCode { get { return Op.OpMemoryBarrier; } }

		public uint Memory { get; set; }
		public uint Semantics { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Memory = Spv.IdScope.Parse(reader, end-reader.Position);
		    Semantics = Spv.IdMemorySemantics.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Memory} {Semantics}";
        }
    }
}
