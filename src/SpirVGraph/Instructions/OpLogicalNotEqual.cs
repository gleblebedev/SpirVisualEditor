using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpLogicalNotEqual: InstructionWithId
    {
        public OpLogicalNotEqual()
        {
        }

        public override Op OpCode { get { return Op.OpLogicalNotEqual; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Operand1 { get; set; }
		public Spv.IdRef Operand2 { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Operand1", Operand1);
		    yield return new ReferenceProperty("Operand2", Operand2);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Operand1 = Spv.IdRef.Parse(reader, end-reader.Position);
		    Operand2 = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Operand1} {Operand2}";
        }
    }
}
