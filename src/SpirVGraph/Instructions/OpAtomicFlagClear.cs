using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpAtomicFlagClear: Instruction
    {
        public OpAtomicFlagClear()
        {
        }

        public override Op OpCode { get { return Op.OpAtomicFlagClear; } }

		public Spv.IdRef Pointer { get; set; }
		public uint Scope { get; set; }
		public uint Semantics { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Pointer", Pointer);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Pointer = Spv.IdRef.Parse(reader, end-reader.Position);
		    Scope = Spv.IdScope.Parse(reader, end-reader.Position);
		    Semantics = Spv.IdMemorySemantics.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Pointer} {Scope} {Semantics}";
        }
    }
}
