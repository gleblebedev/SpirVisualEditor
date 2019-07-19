using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpCompositeConstruct: Instruction
    {
        public OpCompositeConstruct()
        {
        }

        public override Op OpCode { get { return Op.OpCompositeConstruct; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public IList<uint> Constituents { get; set; }

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
		    Constituents = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Constituents}";
        }
    }
}
