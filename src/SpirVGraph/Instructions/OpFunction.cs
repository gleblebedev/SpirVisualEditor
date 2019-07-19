using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpFunction: Instruction
    {
        public OpFunction()
        {
        }

        public override Op OpCode { get { return Op.OpFunction; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public FunctionControl FunctionControl { get; set; }
		public uint FunctionType { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    FunctionControl = FunctionControl.Parse(reader, end-reader.Position);
		    FunctionType = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {FunctionControl} {FunctionType}";
        }
    }
}
