using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpShiftRightArithmetic: Instruction
    {
        public OpShiftRightArithmetic()
        {
        }

        public override Op OpCode { get { return Op.OpShiftRightArithmetic; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Base { get; set; }
		public uint Shift { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Base = ParseWord(reader, end-reader.Position);
		    Shift = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Base} {Shift}";
        }
    }
}
