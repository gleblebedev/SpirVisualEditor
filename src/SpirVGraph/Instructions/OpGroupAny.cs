using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpGroupAny: InstructionWithId
    {
        public OpGroupAny()
        {
        }

        public override Op OpCode { get { return Op.OpGroupAny; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public uint Execution { get; set; }
		public Spv.IdRef Predicate { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Predicate", Predicate);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Execution = Spv.IdScope.Parse(reader, end-reader.Position);
		    Predicate = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Execution} {Predicate}";
        }
    }
}
