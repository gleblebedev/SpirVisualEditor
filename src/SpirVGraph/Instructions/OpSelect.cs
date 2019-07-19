using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSelect: Instruction
    {
        public OpSelect()
        {
        }

        public override Op OpCode { get { return Op.OpSelect; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Condition { get; set; }
		public uint Object1 { get; set; }
		public uint Object2 { get; set; }

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
		    Condition = ParseWord(reader, end-reader.Position);
		    Object1 = ParseWord(reader, end-reader.Position);
		    Object2 = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Condition} {Object1} {Object2}";
        }
    }
}
