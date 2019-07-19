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
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    Execution = Spv.IdScope.Parse(reader, end-reader.Position);
		    Destination = Spv.IdRef.Parse(reader, end-reader.Position);
		    Source = Spv.IdRef.Parse(reader, end-reader.Position);
		    NumElements = Spv.IdRef.Parse(reader, end-reader.Position);
		    Stride = Spv.IdRef.Parse(reader, end-reader.Position);
		    Event = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Execution} {Destination} {Source} {NumElements} {Stride} {Event}";
        }
    }
}
