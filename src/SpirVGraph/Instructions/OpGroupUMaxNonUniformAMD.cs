using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpGroupUMaxNonUniformAMD: InstructionWithId
    {
        public OpGroupUMaxNonUniformAMD()
        {
        }

        public override Op OpCode { get { return Op.OpGroupUMaxNonUniformAMD; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public uint Execution { get; set; }
		public Spv.GroupOperation Operation { get; set; }
		public Spv.IdRef X { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("X", X);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Execution = Spv.IdScope.Parse(reader, end-reader.Position);
		    Operation = Spv.GroupOperation.Parse(reader, end-reader.Position);
		    X = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Execution} {Operation} {X}";
        }
    }
}
