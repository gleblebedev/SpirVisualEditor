using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpCompositeExtract: Instruction
    {
        public OpCompositeExtract()
        {
        }

        public override Op OpCode { get { return Op.OpCompositeExtract; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Composite { get; set; }
		public IList<uint> Indexes { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Composite = ParseWord(reader, end-reader.Position);
		    Indexes = ParseWordCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Composite} {Indexes}";
        }
    }
}
