using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeMatrix: Instruction
    {
        public OpTypeMatrix()
        {
        }

        public override Op OpCode { get { return Op.OpTypeMatrix; } }

		public uint IdResult { get; set; }
		public uint ColumnType { get; set; }
		public uint ColumnCount { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    ColumnType = Spv.IdRef.Parse(reader, end-reader.Position);
		    ColumnCount = Spv.LiteralInteger.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {ColumnType} {ColumnCount}";
        }
    }
}
