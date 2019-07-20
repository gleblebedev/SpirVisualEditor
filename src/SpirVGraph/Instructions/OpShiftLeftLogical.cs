using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpShiftLeftLogical: InstructionWithId
    {
        public OpShiftLeftLogical()
        {
        }

        public override Op OpCode { get { return Op.OpShiftLeftLogical; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Base { get; set; }
		public Spv.IdRef Shift { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Base", Base);
		    yield return new ReferenceProperty("Shift", Shift);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Base = Spv.IdRef.Parse(reader, end-reader.Position);
		    Shift = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Base} {Shift}";
        }
    }
}
