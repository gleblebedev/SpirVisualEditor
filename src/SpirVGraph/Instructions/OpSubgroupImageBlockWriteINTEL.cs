using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSubgroupImageBlockWriteINTEL: Instruction
    {
        public OpSubgroupImageBlockWriteINTEL()
        {
        }

        public override Op OpCode { get { return Op.OpSubgroupImageBlockWriteINTEL; } }

		public Spv.IdRef Image { get; set; }
		public Spv.IdRef Coordinate { get; set; }
		public Spv.IdRef Data { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Image", Image);
		    yield return new ReferenceProperty("Coordinate", Coordinate);
		    yield return new ReferenceProperty("Data", Data);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Image = Spv.IdRef.Parse(reader, end-reader.Position);
		    Coordinate = Spv.IdRef.Parse(reader, end-reader.Position);
		    Data = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Image} {Coordinate} {Data}";
        }
    }
}
