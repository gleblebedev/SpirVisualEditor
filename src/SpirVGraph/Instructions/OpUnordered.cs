using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpUnordered: Instruction
    {
        public OpUnordered()
        {
        }

        public override Op OpCode { get { return Op.OpUnordered; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint x { get; set; }
		public uint y { get; set; }

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
		    x = ParseWord(reader, end-reader.Position);
		    y = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {x} {y}";
        }
    }
}
