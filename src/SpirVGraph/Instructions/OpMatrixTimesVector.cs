using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpMatrixTimesVector: Instruction
    {
        public OpMatrixTimesVector()
        {
        }

        public override Op OpCode { get { return Op.OpMatrixTimesVector; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Matrix { get; set; }
		public uint Vector { get; set; }

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
		    Matrix = Spv.IdRef.Parse(reader, end-reader.Position);
		    Vector = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Matrix} {Vector}";
        }
    }
}
