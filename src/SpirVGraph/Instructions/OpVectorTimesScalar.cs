using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpVectorTimesScalar: InstructionWithId
    {
        public OpVectorTimesScalar()
        {
        }

        public override Op OpCode { get { return Op.OpVectorTimesScalar; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Vector { get; set; }
		public Spv.IdRef Scalar { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Vector", Vector);
		    yield return new ReferenceProperty("Scalar", Scalar);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Vector = Spv.IdRef.Parse(reader, end-reader.Position);
		    Scalar = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Vector} {Scalar}";
        }
    }
}
