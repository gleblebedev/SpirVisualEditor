using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpFunctionParameter: Instruction
    {
        public OpFunctionParameter()
        {
        }

        public override Op OpCode { get { return Op.OpFunctionParameter; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult}";
        }
    }
}
