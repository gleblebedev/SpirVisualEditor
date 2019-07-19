using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpConvertFToU: Instruction
    {
        public OpConvertFToU()
        {
        }

        public override Op OpCode { get { return Op.OpConvertFToU; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint FloatValue { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    FloatValue = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {FloatValue}";
        }
    }
}
