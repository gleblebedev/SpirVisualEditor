using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSampledImage: Instruction
    {
        public OpSampledImage()
        {
        }

        public override Op OpCode { get { return Op.OpSampledImage; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Image { get; set; }
		public uint Sampler { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    Image = Spv.IdRef.Parse(reader, end-reader.Position);
		    Sampler = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Image} {Sampler}";
        }
    }
}
