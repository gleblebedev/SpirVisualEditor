using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpAtomicCompareExchange: Instruction
    {
        public OpAtomicCompareExchange()
        {
        }

        public override Op OpCode { get { return Op.OpAtomicCompareExchange; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Pointer { get; set; }
		public uint Scope { get; set; }
		public uint Equal { get; set; }
		public uint Unequal { get; set; }
		public uint Value { get; set; }
		public uint Comparator { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Pointer = ParseWord(reader, end-reader.Position);
		    Scope = ParseWord(reader, end-reader.Position);
		    Equal = ParseWord(reader, end-reader.Position);
		    Unequal = ParseWord(reader, end-reader.Position);
		    Value = ParseWord(reader, end-reader.Position);
		    Comparator = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Pointer} {Scope} {Equal} {Unequal} {Value} {Comparator}";
        }
    }
}
