using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeImage: Instruction
    {
        public OpTypeImage()
        {
        }

        public override Op OpCode { get { return Op.OpTypeImage; } }

		public uint IdResult { get; set; }
		public uint SampledType { get; set; }
		public Dim Dim { get; set; }
		public uint Depth { get; set; }
		public uint Arrayed { get; set; }
		public uint MS { get; set; }
		public uint Sampled { get; set; }
		public ImageFormat ImageFormat { get; set; }
		public AccessQualifier AccessQualifier { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    SampledType = ParseWord(reader, end-reader.Position);
		    Dim = Dim.Parse(reader, end-reader.Position);
		    Depth = ParseWord(reader, end-reader.Position);
		    Arrayed = ParseWord(reader, end-reader.Position);
		    MS = ParseWord(reader, end-reader.Position);
		    Sampled = ParseWord(reader, end-reader.Position);
		    ImageFormat = ImageFormat.Parse(reader, end-reader.Position);
		    AccessQualifier = AccessQualifier.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {SampledType} {Dim} {Depth} {Arrayed} {MS} {Sampled} {ImageFormat} {AccessQualifier}";
        }
    }
}
