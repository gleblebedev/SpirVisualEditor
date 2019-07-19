using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpFunctionCall: Instruction
    {
        public OpFunctionCall()
        {
        }

        public override Op OpCode { get { return Op.OpFunctionCall; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Function { get; set; }
		public IList<uint> Arguments { get; set; }

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
		    Function = ParseWord(reader, end-reader.Position);
		    Arguments = ParseWordCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Function} {Arguments}";
        }
    }
}
