using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpFunction: InstructionWithId
    {
        public OpFunction()
        {
        }

        public override Op OpCode { get { return Op.OpFunction; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.FunctionControl FunctionControl { get; set; }
		public Spv.IdRef FunctionType { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("FunctionType", FunctionType);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    FunctionControl = Spv.FunctionControl.Parse(reader, end-reader.Position);
		    FunctionType = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {FunctionControl} {FunctionType}";
        }
    }
}
