using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpAny: InstructionWithId
    {
        public OpAny()
        {
        }

        public override Op OpCode { get { return Op.OpAny; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Vector { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Vector", Vector);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Vector = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Vector}";
        }
    }
}
