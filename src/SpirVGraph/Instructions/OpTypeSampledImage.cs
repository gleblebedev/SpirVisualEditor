using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeSampledImage: Instruction
    {
        public OpTypeSampledImage()
        {
        }

        public override Op OpCode { get { return Op.OpTypeSampledImage; } }

		public uint IdResult { get; set; }
		public uint ImageType { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    ImageType = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResult} {ImageType}";
        }
    }
}
