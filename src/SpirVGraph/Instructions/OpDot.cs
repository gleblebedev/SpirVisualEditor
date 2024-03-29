using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpDot: InstructionWithId
    {
        public OpDot()
        {
        }

        public override Op OpCode { get { return Op.OpDot; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Vector1 { get; set; }
		public Spv.IdRef Vector2 { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Vector1", Vector1);
		    yield return new ReferenceProperty("Vector2", Vector2);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Vector1 = Spv.IdRef.Parse(reader, end-reader.Position);
		    Vector2 = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Vector1} {Vector2}";
        }
    }
}
