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

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    ColumnType = ParseWord(reader, end-reader.Position);
		    ColumnCount = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResult} {ColumnType} {ColumnCount}";
        }
    }
}
