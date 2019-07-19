using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupUMaxNonUniformAMD: Instruction
    {
        public OpGroupUMaxNonUniformAMD()
        {
        }

        public override Op OpCode { get { return Op.OpGroupUMaxNonUniformAMD; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Execution { get; set; }
		public Spv.GroupOperation Operation { get; set; }
		public uint X { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
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
