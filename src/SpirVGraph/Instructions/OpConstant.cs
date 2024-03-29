using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpConstant: InstructionWithId
    {
        public OpConstant()
        {
        }

        public override Op OpCode { get { return Op.OpConstant; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.LiteralContextDependentNumber Value { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Value = Spv.LiteralContextDependentNumber.ParseOptional(reader, end-reader.Position, IdResultType.Instruction);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Value}";
        }
    }
}
