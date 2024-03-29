using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpReadPipe: InstructionWithId
    {
        public OpReadPipe()
        {
        }

        public override Op OpCode { get { return Op.OpReadPipe; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Pipe { get; set; }
		public Spv.IdRef Pointer { get; set; }
		public Spv.IdRef PacketSize { get; set; }
		public Spv.IdRef PacketAlignment { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Pipe", Pipe);
		    yield return new ReferenceProperty("Pointer", Pointer);
		    yield return new ReferenceProperty("PacketSize", PacketSize);
		    yield return new ReferenceProperty("PacketAlignment", PacketAlignment);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Pipe = Spv.IdRef.Parse(reader, end-reader.Position);
		    Pointer = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketAlignment = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Pipe} {Pointer} {PacketSize} {PacketAlignment}";
        }
    }
}
