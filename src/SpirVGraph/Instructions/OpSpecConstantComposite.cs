using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSpecConstantComposite: Instruction
    {
        public OpSpecConstantComposite()
        {
        }

        public override Op OpCode { get { return Op.OpSpecConstantComposite; } }

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
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Constituents = ParseWordCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Constituents}";
        }
    }
}
