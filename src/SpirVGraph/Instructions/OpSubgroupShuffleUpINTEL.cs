using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSubgroupShuffleUpINTEL: InstructionWithId
    {
        public OpSubgroupShuffleUpINTEL()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupShuffleUpINTEL; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Previous { get; set; }
		public Spv.IdRef Current { get; set; }
		public Spv.IdRef Delta { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Previous", Previous);
		    yield return new ReferenceProperty("Current", Current);
		    yield return new ReferenceProperty("Delta", Delta);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Previous = Spv.IdRef.Parse(reader, end-reader.Position);
		    Current = Spv.IdRef.Parse(reader, end-reader.Position);
		    Delta = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Previous} {Current} {Delta}";
        }
    }
}
