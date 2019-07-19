using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpMatrixTimesScalar: Instruction
    {
        public OpMatrixTimesScalar()
        {
        }

        public override Op OpCode { get { return Op.OpMatrixTimesScalar; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Matrix { get; set; }
		public uint Scalar { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Matrix = ParseWord(reader, end-reader.Position);
		    Scalar = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Matrix} {Scalar}";
        }
    }
}
