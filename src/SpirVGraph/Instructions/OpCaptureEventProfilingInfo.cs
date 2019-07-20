using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpCaptureEventProfilingInfo: Instruction
    {
        public OpCaptureEventProfilingInfo()
        {
        }

        public override Op OpCode { get { return Op.OpCaptureEventProfilingInfo; } }

		public Spv.IdRef Event { get; set; }
		public Spv.IdRef ProfilingInfo { get; set; }
		public Spv.IdRef Value { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Event", Event);
		    yield return new ReferenceProperty("ProfilingInfo", ProfilingInfo);
		    yield return new ReferenceProperty("Value", Value);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Event = Spv.IdRef.Parse(reader, end-reader.Position);
		    ProfilingInfo = Spv.IdRef.Parse(reader, end-reader.Position);
		    Value = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Event} {ProfilingInfo} {Value}";
        }
    }
}
