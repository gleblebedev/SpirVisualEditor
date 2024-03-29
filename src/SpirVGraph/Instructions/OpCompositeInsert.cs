using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpCompositeInsert: InstructionWithId
    {
        public OpCompositeInsert()
        {
        }

        public override Op OpCode { get { return Op.OpCompositeInsert; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Object { get; set; }
		public Spv.IdRef Composite { get; set; }
		public IList<uint> Indexes { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Object", Object);
		    yield return new ReferenceProperty("Composite", Composite);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Object = Spv.IdRef.Parse(reader, end-reader.Position);
		    Composite = Spv.IdRef.Parse(reader, end-reader.Position);
		    Indexes = Spv.LiteralInteger.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Object} {Composite} {Indexes}";
        }
    }
}
