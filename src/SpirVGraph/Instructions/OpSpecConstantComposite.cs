using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSpecConstantComposite: InstructionWithId
    {
        public OpSpecConstantComposite()
        {
        }

        public override Op OpCode { get { return Op.OpSpecConstantComposite; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public IList<Spv.IdRef> Constituents { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
			for (int i=0; i<Constituents.Count; ++i)
				yield return new ReferenceProperty("Constituents"+i, Constituents[i]);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Constituents = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Constituents}";
        }
    }
}
