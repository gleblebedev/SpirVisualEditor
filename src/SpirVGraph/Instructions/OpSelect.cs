using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSelect: InstructionWithId
    {
        public OpSelect()
        {
        }

        public override Op OpCode { get { return Op.OpSelect; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Condition { get; set; }
		public Spv.IdRef Object1 { get; set; }
		public Spv.IdRef Object2 { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Condition", Condition);
		    yield return new ReferenceProperty("Object1", Object1);
		    yield return new ReferenceProperty("Object2", Object2);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Condition = Spv.IdRef.Parse(reader, end-reader.Position);
		    Object1 = Spv.IdRef.Parse(reader, end-reader.Position);
		    Object2 = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Condition} {Object1} {Object2}";
        }
    }
}
