using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpGroupBroadcast: InstructionWithId
    {
        public OpGroupBroadcast()
        {
        }

        public override Op OpCode { get { return Op.OpGroupBroadcast; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public uint Execution { get; set; }
		public Spv.IdRef Value { get; set; }
		public Spv.IdRef LocalId { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Value", Value);
		    yield return new ReferenceProperty("LocalId", LocalId);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Execution = Spv.IdScope.Parse(reader, end-reader.Position);
		    Value = Spv.IdRef.Parse(reader, end-reader.Position);
		    LocalId = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Execution} {Value} {LocalId}";
        }
    }
}
