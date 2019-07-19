using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpCommitReadPipe: Instruction
    {
        public OpCommitReadPipe()
        {
        }

        public override Op OpCode { get { return Op.OpCommitReadPipe; } }

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
		    Pipe = ParseWord(reader, end-reader.Position);
		    ReserveId = ParseWord(reader, end-reader.Position);
		    PacketSize = ParseWord(reader, end-reader.Position);
		    PacketAlignment = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Pipe} {ReserveId} {PacketSize} {PacketAlignment}";
        }
    }
}