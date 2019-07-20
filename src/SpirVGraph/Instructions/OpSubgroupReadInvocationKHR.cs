using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSubgroupReadInvocationKHR: InstructionWithId
    {
        public OpSubgroupReadInvocationKHR()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupReadInvocationKHR; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Value { get; set; }
		public Spv.IdRef Index { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Value", Value);
		    yield return new ReferenceProperty("Index", Index);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Value = Spv.IdRef.Parse(reader, end-reader.Position);
		    Index = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Value} {Index}";
        }
    }
}
