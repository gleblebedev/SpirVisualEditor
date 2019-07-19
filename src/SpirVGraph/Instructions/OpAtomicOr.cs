using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpAtomicOr: Instruction
    {
        public OpAtomicOr()
        {
        }

        public override Op OpCode { get { return Op.OpAtomicOr; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Pointer { get; set; }
		public uint Scope { get; set; }
		public uint Semantics { get; set; }
		public uint Value { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Pointer = ParseWord(reader, end-reader.Position);
		    Scope = ParseWord(reader, end-reader.Position);
		    Semantics = ParseWord(reader, end-reader.Position);
		    Value = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Pointer} {Scope} {Semantics} {Value}";
        }
    }
}
