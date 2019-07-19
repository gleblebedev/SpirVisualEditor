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
		    Queue = Spv.IdRef.Parse(reader, end-reader.Position);
		    Flags = Spv.IdRef.Parse(reader, end-reader.Position);
		    NDRange = Spv.IdRef.Parse(reader, end-reader.Position);
		    NumEvents = Spv.IdRef.Parse(reader, end-reader.Position);
		    WaitEvents = Spv.IdRef.Parse(reader, end-reader.Position);
		    RetEvent = Spv.IdRef.Parse(reader, end-reader.Position);
		    Invoke = Spv.IdRef.Parse(reader, end-reader.Position);
		    Param = Spv.IdRef.Parse(reader, end-reader.Position);
		    ParamSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    ParamAlign = Spv.IdRef.Parse(reader, end-reader.Position);
		    LocalSize = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Queue} {Flags} {NDRange} {NumEvents} {WaitEvents} {RetEvent} {Invoke} {Param} {ParamSize} {ParamAlign} {LocalSize}";
        }
    }
}
