using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpImageQueryLevels: Instruction
    {
        public OpImageQueryLevels()
        {
        }

        public override Op OpCode { get { return Op.OpImageQueryLevels; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Image { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Image = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Image}";
        }
    }
}
