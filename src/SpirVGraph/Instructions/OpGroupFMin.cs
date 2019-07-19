using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupFMin: Instruction
    {
        public OpGroupFMin()
        {
        }

        public override Op OpCode { get { return Op.OpGroupFMin; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Execution { get; set; }
		public GroupOperation Operation { get; set; }
		public uint X { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Execution = ParseWord(reader, end-reader.Position);
		    Operation = GroupOperation.Parse(reader, end-reader.Position);
		    X = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Execution} {Operation} {X}";
        }
    }
}
