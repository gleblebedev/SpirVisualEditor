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
		public Spv.ImageOperands ImageOperands { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Image = Spv.IdRef.Parse(reader, end-reader.Position);
		    Coordinate = Spv.IdRef.Parse(reader, end-reader.Position);
		    Texel = Spv.IdRef.Parse(reader, end-reader.Position);
		    ImageOperands = Spv.ImageOperands.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Image} {Coordinate} {Texel} {ImageOperands}";
        }
    }
}
