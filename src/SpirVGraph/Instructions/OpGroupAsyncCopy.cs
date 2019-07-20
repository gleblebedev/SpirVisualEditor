using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpGroupAsyncCopy: InstructionWithId
    {
        public OpGroupAsyncCopy()
        {
        }

        public override Op OpCode { get { return Op.OpGroupAsyncCopy; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public uint Execution { get; set; }
		public Spv.IdRef Destination { get; set; }
		public Spv.IdRef Source { get; set; }
		public Spv.IdRef NumElements { get; set; }
		public Spv.IdRef Stride { get; set; }
		public Spv.IdRef Event { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Destination", Destination);
		    yield return new ReferenceProperty("Source", Source);
		    yield return new ReferenceProperty("NumElements", NumElements);
		    yield return new ReferenceProperty("Stride", Stride);
		    yield return new ReferenceProperty("Event", Event);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
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
