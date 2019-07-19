using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpFunction: Instruction
    {
        public OpFunction()
        {
        }

        public override Op OpCode { get { return Op.OpFunction; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public Spv.FunctionControl FunctionControl { get; set; }
		public uint FunctionType { get; set; }

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
		    FunctionControl = Spv.FunctionControl.Parse(reader, end-reader.Position);
		    FunctionType = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {FunctionControl} {FunctionType}";
        }
    }
}
