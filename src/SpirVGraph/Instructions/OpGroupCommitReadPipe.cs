using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupCommitReadPipe: Instruction
    {
        public OpGroupCommitReadPipe()
        {
        }

        public override Op OpCode { get { return Op.OpGroupCommitReadPipe; } }

		public uint Execution { get; set; }
		public uint Pipe { get; set; }
		public uint ReserveId { get; set; }
		public uint PacketSize { get; set; }
		public uint PacketAlignment { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Execution = Spv.IdScope.Parse(reader, end-reader.Position);
		    Pipe = Spv.IdRef.Parse(reader, end-reader.Position);
		    ReserveId = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketAlignment = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Execution} {Pipe} {ReserveId} {PacketSize} {PacketAlignment}";
        }
    }
}
