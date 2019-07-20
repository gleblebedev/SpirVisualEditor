using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpEnqueueMarker: InstructionWithId
    {
        public OpEnqueueMarker()
        {
        }

        public override Op OpCode { get { return Op.OpEnqueueMarker; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Queue { get; set; }
		public Spv.IdRef NumEvents { get; set; }
		public Spv.IdRef WaitEvents { get; set; }
		public Spv.IdRef RetEvent { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Queue", Queue);
		    yield return new ReferenceProperty("NumEvents", NumEvents);
		    yield return new ReferenceProperty("WaitEvents", WaitEvents);
		    yield return new ReferenceProperty("RetEvent", RetEvent);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Queue = Spv.IdRef.Parse(reader, end-reader.Position);
		    NumEvents = Spv.IdRef.Parse(reader, end-reader.Position);
		    WaitEvents = Spv.IdRef.Parse(reader, end-reader.Position);
		    RetEvent = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Queue} {NumEvents} {WaitEvents} {RetEvent}";
        }
    }
}
