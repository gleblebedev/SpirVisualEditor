using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpImageWrite: Instruction
    {
        public OpImageWrite()
        {
        }

        public override Op OpCode { get { return Op.OpImageWrite; } }

		public uint Image { get; set; }
		public uint Coordinate { get; set; }
		public uint Texel { get; set; }
		public ImageOperands ImageOperands { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Image = ParseWord(reader, end-reader.Position);
		    Coordinate = ParseWord(reader, end-reader.Position);
		    Texel = ParseWord(reader, end-reader.Position);
		    ImageOperands = ImageOperands.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Image} {Coordinate} {Texel} {ImageOperands}";
        }
    }
}
