using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpFUnordGreaterThanEqual: Instruction
    {
        public OpFUnordGreaterThanEqual()
        {
        }

        public override Op OpCode { get { return Op.OpFUnordGreaterThanEqual; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Operand1 { get; set; }
		public uint Operand2 { get; set; }

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
		    Operand1 = Spv.IdRef.Parse(reader, end-reader.Position);
		    Operand2 = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Operand1} {Operand2}";
        }
    }
}
