using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpFUnordEqual: Instruction
    {
        public OpFUnordEqual()
        {
        }

        public override Op OpCode { get { return Op.OpFUnordEqual; } }

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
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Operand1 = ParseWord(reader, end-reader.Position);
		    Operand2 = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Operand1} {Operand2}";
        }
    }
}
