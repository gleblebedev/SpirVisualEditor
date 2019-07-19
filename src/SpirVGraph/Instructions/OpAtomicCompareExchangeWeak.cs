using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpAtomicCompareExchangeWeak: Instruction
    {
        public OpAtomicCompareExchangeWeak()
        {
        }

        public override Op OpCode { get { return Op.OpAtomicCompareExchangeWeak; } }

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
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    Pointer = Spv.IdRef.Parse(reader, end-reader.Position);
		    Scope = Spv.IdScope.Parse(reader, end-reader.Position);
		    Equal = Spv.IdMemorySemantics.Parse(reader, end-reader.Position);
		    Unequal = Spv.IdMemorySemantics.Parse(reader, end-reader.Position);
		    Value = Spv.IdRef.Parse(reader, end-reader.Position);
		    Comparator = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Pointer} {Scope} {Equal} {Unequal} {Value} {Comparator}";
        }
    }
}
