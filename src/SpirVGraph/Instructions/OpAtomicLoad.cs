using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpAtomicLoad: InstructionWithId
    {
        public OpAtomicLoad()
        {
        }

        public override Op OpCode { get { return Op.OpAtomicLoad; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
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
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Pointer = Spv.IdRef.Parse(reader, end-reader.Position);
		    Scope = Spv.IdScope.Parse(reader, end-reader.Position);
		    Semantics = Spv.IdMemorySemantics.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Pointer} {Scope} {Semantics}";
        }
    }
}
