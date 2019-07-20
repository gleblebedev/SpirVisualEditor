using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpPtrAccessChain: InstructionWithId
    {
        public OpPtrAccessChain()
        {
        }

        public override Op OpCode { get { return Op.OpPtrAccessChain; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Base { get; set; }
		public Spv.IdRef Element { get; set; }
		public IList<Spv.IdRef> Indexes { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Base", Base);
		    yield return new ReferenceProperty("Element", Element);
			for (int i=0; i<Indexes.Count; ++i)
				yield return new ReferenceProperty("Indexes"+i, Indexes[i]);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Base = Spv.IdRef.Parse(reader, end-reader.Position);
		    Element = Spv.IdRef.Parse(reader, end-reader.Position);
		    Indexes = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Base} {Element} {Indexes}";
        }
    }
}
