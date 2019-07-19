using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupBroadcast: Instruction
    {
        public OpGroupBroadcast()
        {
        }

        public override Op OpCode { get { return Op.OpGroupBroadcast; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Execution { get; set; }
		public uint Value { get; set; }
		public uint LocalId { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Execution = ParseWord(reader, end-reader.Position);
		    Value = ParseWord(reader, end-reader.Position);
		    LocalId = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Execution} {Value} {LocalId}";
        }
    }
}
