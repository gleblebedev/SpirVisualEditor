using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpAtomicFlagClear: Instruction
    {
        public OpAtomicFlagClear()
        {
        }

        public override Op OpCode { get { return Op.OpAtomicFlagClear; } }

		public uint Pointer { get; set; }
		public uint Scope { get; set; }
		public uint Semantics { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Pointer = ParseWord(reader, end-reader.Position);
		    Scope = ParseWord(reader, end-reader.Position);
		    Semantics = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Pointer} {Scope} {Semantics}";
        }
    }
}
