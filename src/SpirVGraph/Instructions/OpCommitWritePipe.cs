using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpCommitWritePipe: Instruction
    {
        public OpCommitWritePipe()
        {
        }

        public override Op OpCode { get { return Op.OpCommitWritePipe; } }

		public Spv.IdRef Pipe { get; set; }
		public Spv.IdRef ReserveId { get; set; }
		public Spv.IdRef PacketSize { get; set; }
		public Spv.IdRef PacketAlignment { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Pipe", Pipe);
		    yield return new ReferenceProperty("ReserveId", ReserveId);
		    yield return new ReferenceProperty("PacketSize", PacketSize);
		    yield return new ReferenceProperty("PacketAlignment", PacketAlignment);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Pipe = Spv.IdRef.Parse(reader, end-reader.Position);
		    ReserveId = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketAlignment = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Pipe} {ReserveId} {PacketSize} {PacketAlignment}";
        }
    }
}
