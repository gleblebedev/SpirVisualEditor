using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpEnqueueKernel: Instruction
    {
        public OpEnqueueKernel()
        {
        }

        public override Op OpCode { get { return Op.OpEnqueueKernel; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Queue { get; set; }
		public uint Flags { get; set; }
		public uint NDRange { get; set; }
		public uint NumEvents { get; set; }
		public uint WaitEvents { get; set; }
		public uint RetEvent { get; set; }
		public uint Invoke { get; set; }
		public uint Param { get; set; }
		public uint ParamSize { get; set; }
		public uint ParamAlign { get; set; }
		public IList<uint> LocalSize { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Queue = ParseWord(reader, end-reader.Position);
		    Flags = ParseWord(reader, end-reader.Position);
		    NDRange = ParseWord(reader, end-reader.Position);
		    NumEvents = ParseWord(reader, end-reader.Position);
		    WaitEvents = ParseWord(reader, end-reader.Position);
		    RetEvent = ParseWord(reader, end-reader.Position);
		    Invoke = ParseWord(reader, end-reader.Position);
		    Param = ParseWord(reader, end-reader.Position);
		    ParamSize = ParseWord(reader, end-reader.Position);
		    ParamAlign = ParseWord(reader, end-reader.Position);
		    LocalSize = ParseWordCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Queue} {Flags} {NDRange} {NumEvents} {WaitEvents} {RetEvent} {Invoke} {Param} {ParamSize} {ParamAlign} {LocalSize}";
        }
    }
}
