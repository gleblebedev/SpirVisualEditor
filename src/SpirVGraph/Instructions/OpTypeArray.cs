using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeArray: Instruction
    {
        public OpTypeArray()
        {
        }

        public override Op OpCode { get { return Op.OpTypeArray; } }

		public uint IdResult { get; set; }
		public uint ElementType { get; set; }
		public uint Length { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    ElementType = ParseWord(reader, end-reader.Position);
		    Length = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResult} {ElementType} {Length}";
        }
    }
}
