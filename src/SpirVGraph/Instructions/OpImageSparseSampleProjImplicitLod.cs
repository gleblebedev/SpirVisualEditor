using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpImageSparseSampleProjImplicitLod: Instruction
    {
        public OpImageSparseSampleProjImplicitLod()
        {
        }

        public override Op OpCode { get { return Op.OpImageSparseSampleProjImplicitLod; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint SampledImage { get; set; }
		public uint Coordinate { get; set; }
		public ImageOperands ImageOperands { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    SampledImage = ParseWord(reader, end-reader.Position);
		    Coordinate = ParseWord(reader, end-reader.Position);
		    ImageOperands = ImageOperands.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {SampledImage} {Coordinate} {ImageOperands}";
        }
    }
}
