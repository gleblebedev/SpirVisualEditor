using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpBitcast: Instruction
    {
        public OpBitcast()
        {
        }

        public override Op OpCode { get { return Op.OpBitcast; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Operand { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Operand = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Operand}";
        }
    }
}
