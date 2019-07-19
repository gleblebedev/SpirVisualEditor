using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpVectorShuffle: Instruction
    {
        public OpVectorShuffle()
        {
        }

        public override Op OpCode { get { return Op.OpVectorShuffle; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Vector1 { get; set; }
		public uint Vector2 { get; set; }
		public IList<uint> Components { get; set; }

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
		    Vector1 = Spv.IdRef.Parse(reader, end-reader.Position);
		    Vector2 = Spv.IdRef.Parse(reader, end-reader.Position);
		    Components = Spv.LiteralInteger.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Vector1} {Vector2} {Components}";
        }
    }
}
