using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpBitFieldInsert: InstructionWithId
    {
        public OpBitFieldInsert()
        {
        }

        public override Op OpCode { get { return Op.OpBitFieldInsert; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Base { get; set; }
		public Spv.IdRef Insert { get; set; }
		public Spv.IdRef Offset { get; set; }
		public Spv.IdRef Count { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Base", Base);
		    yield return new ReferenceProperty("Insert", Insert);
		    yield return new ReferenceProperty("Offset", Offset);
		    yield return new ReferenceProperty("Count", Count);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Base = Spv.IdRef.Parse(reader, end-reader.Position);
		    Insert = Spv.IdRef.Parse(reader, end-reader.Position);
		    Offset = Spv.IdRef.Parse(reader, end-reader.Position);
		    Count = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Base} {Insert} {Offset} {Count}";
        }
    }
}
