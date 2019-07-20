using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSetUserEventStatus: Instruction
    {
        public OpSetUserEventStatus()
        {
        }

        public override Op OpCode { get { return Op.OpSetUserEventStatus; } }

		public Spv.IdRef Event { get; set; }
		public Spv.IdRef Status { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Event", Event);
		    yield return new ReferenceProperty("Status", Status);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Event = Spv.IdRef.Parse(reader, end-reader.Position);
		    Status = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Event} {Status}";
        }
    }
}
