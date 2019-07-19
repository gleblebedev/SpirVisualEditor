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
		public Spv.Dim Dim { get; set; }
		public uint Depth { get; set; }
		public uint Arrayed { get; set; }
		public uint MS { get; set; }
		public uint Sampled { get; set; }
		public Spv.ImageFormat ImageFormat { get; set; }
		public Spv.AccessQualifier AccessQualifier { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    SampledType = Spv.IdRef.Parse(reader, end-reader.Position);
		    Dim = Spv.Dim.Parse(reader, end-reader.Position);
		    Depth = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    Arrayed = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    MS = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    Sampled = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    ImageFormat = Spv.ImageFormat.Parse(reader, end-reader.Position);
		    AccessQualifier = Spv.AccessQualifier.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {SampledType} {Dim} {Depth} {Arrayed} {MS} {Sampled} {ImageFormat} {AccessQualifier}";
        }
    }
}
