using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpMatrixTimesMatrix: InstructionWithId
    {
        public OpMatrixTimesMatrix()
        {
        }

        public override Op OpCode { get { return Op.OpMatrixTimesMatrix; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef LeftMatrix { get; set; }
		public Spv.IdRef RightMatrix { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("LeftMatrix", LeftMatrix);
		    yield return new ReferenceProperty("RightMatrix", RightMatrix);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    LeftMatrix = Spv.IdRef.Parse(reader, end-reader.Position);
		    RightMatrix = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {LeftMatrix} {RightMatrix}";
        }
    }
}
