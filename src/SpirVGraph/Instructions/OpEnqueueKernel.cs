using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpEnqueueKernel: InstructionWithId
    {
        public OpEnqueueKernel()
        {
        }

        public override Op OpCode { get { return Op.OpEnqueueKernel; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Queue { get; set; }
		public Spv.IdRef Flags { get; set; }
		public Spv.IdRef NDRange { get; set; }
		public Spv.IdRef NumEvents { get; set; }
		public Spv.IdRef WaitEvents { get; set; }
		public Spv.IdRef RetEvent { get; set; }
		public Spv.IdRef Invoke { get; set; }
		public Spv.IdRef Param { get; set; }
		public Spv.IdRef ParamSize { get; set; }
		public Spv.IdRef ParamAlign { get; set; }
		public IList<Spv.IdRef> LocalSize { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Queue", Queue);
		    yield return new ReferenceProperty("Flags", Flags);
		    yield return new ReferenceProperty("NDRange", NDRange);
		    yield return new ReferenceProperty("NumEvents", NumEvents);
		    yield return new ReferenceProperty("WaitEvents", WaitEvents);
		    yield return new ReferenceProperty("RetEvent", RetEvent);
		    yield return new ReferenceProperty("Invoke", Invoke);
		    yield return new ReferenceProperty("Param", Param);
		    yield return new ReferenceProperty("ParamSize", ParamSize);
		    yield return new ReferenceProperty("ParamAlign", ParamAlign);
			for (int i=0; i<LocalSize.Count; ++i)
				yield return new ReferenceProperty("LocalSize"+i, LocalSize[i]);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
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
