using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpLessOrGreater: Instruction
    {
        public OpLessOrGreater()
        {
        }

        public override Op OpCode { get { return Op.OpLessOrGreater; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint x { get; set; }
		public uint y { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    x = ParseWord(reader, end-reader.Position);
		    y = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {x} {y}";
        }
    }
}
