using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeInt: Instruction
    {
        public OpTypeInt()
        {
        }

        public override Op OpCode { get { return Op.OpTypeInt; } }

		public uint IdResult { get; set; }
		public uint Width { get; set; }
		public uint Signedness { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    Width = ParseWord(reader, end-reader.Position);
		    Signedness = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResult} {Width} {Signedness}";
        }
    }
}
