using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGetKernelNDrangeMaxSubGroupSize: Instruction
    {
        public OpGetKernelNDrangeMaxSubGroupSize()
        {
        }

        public override Op OpCode { get { return Op.OpGetKernelNDrangeMaxSubGroupSize; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint NDRange { get; set; }
		public uint Invoke { get; set; }
		public uint Param { get; set; }
		public uint ParamSize { get; set; }
		public uint ParamAlign { get; set; }

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
		    NDRange = ParseWord(reader, end-reader.Position);
		    Invoke = ParseWord(reader, end-reader.Position);
		    Param = ParseWord(reader, end-reader.Position);
		    ParamSize = ParseWord(reader, end-reader.Position);
		    ParamAlign = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {NDRange} {Invoke} {Param} {ParamSize} {ParamAlign}";
        }
    }
}
