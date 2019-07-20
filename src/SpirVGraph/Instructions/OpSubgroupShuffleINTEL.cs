using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSubgroupShuffleINTEL: InstructionWithId
    {
        public OpSubgroupShuffleINTEL()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupShuffleINTEL; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Data { get; set; }
		public Spv.IdRef InvocationId { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Data", Data);
		    yield return new ReferenceProperty("InvocationId", InvocationId);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Data = Spv.IdRef.Parse(reader, end-reader.Position);
		    InvocationId = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Data} {InvocationId}";
        }
    }
}
