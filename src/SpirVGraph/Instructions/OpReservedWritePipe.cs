using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpReservedWritePipe: Instruction
    {
        public OpReservedWritePipe()
        {
        }

        public override Op OpCode { get { return Op.OpReservedWritePipe; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Pipe { get; set; }
		public uint ReserveId { get; set; }
		public uint Index { get; set; }
		public uint Pointer { get; set; }
		public uint PacketSize { get; set; }
		public uint PacketAlignment { get; set; }

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
		    Pipe = Spv.IdRef.Parse(reader, end-reader.Position);
		    ReserveId = Spv.IdRef.Parse(reader, end-reader.Position);
		    Index = Spv.IdRef.Parse(reader, end-reader.Position);
		    Pointer = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketAlignment = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Pipe} {ReserveId} {Index} {Pointer} {PacketSize} {PacketAlignment}";
        }
    }
}
