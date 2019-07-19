using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupAsyncCopy: Instruction
    {
        public OpGroupAsyncCopy()
        {
        }

        public override Op OpCode { get { return Op.OpGroupAsyncCopy; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Execution { get; set; }
		public uint Destination { get; set; }
		public uint Source { get; set; }
		public uint NumElements { get; set; }
		public uint Stride { get; set; }
		public uint Event { get; set; }

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
		    Execution = ParseWord(reader, end-reader.Position);
		    Destination = ParseWord(reader, end-reader.Position);
		    Source = ParseWord(reader, end-reader.Position);
		    NumElements = ParseWord(reader, end-reader.Position);
		    Stride = ParseWord(reader, end-reader.Position);
		    Event = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Execution} {Destination} {Source} {NumElements} {Stride} {Event}";
        }
    }
}
