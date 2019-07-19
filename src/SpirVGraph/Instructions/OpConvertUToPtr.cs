using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpConvertUToPtr: Instruction
    {
        public OpConvertUToPtr()
        {
        }

        public override Op OpCode { get { return Op.OpConvertUToPtr; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint IntegerValue { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    IntegerValue = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {IntegerValue}";
        }
    }
}
