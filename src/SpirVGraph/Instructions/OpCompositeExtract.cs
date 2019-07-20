using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpCompositeExtract: InstructionWithId
    {
        public OpCompositeExtract()
        {
        }

        public override Op OpCode { get { return Op.OpCompositeExtract; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Composite { get; set; }
		public IList<uint> Indexes { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Composite", Composite);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Composite = Spv.IdRef.Parse(reader, end-reader.Position);
		    Indexes = Spv.LiteralInteger.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Composite} {Indexes}";
        }
    }
}
