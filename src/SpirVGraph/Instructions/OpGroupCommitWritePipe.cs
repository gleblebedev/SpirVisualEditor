using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupCommitWritePipe: Instruction
    {
        public OpGroupCommitWritePipe()
        {
        }

        public override Op OpCode { get { return Op.OpGroupCommitWritePipe; } }

		public uint Execution { get; set; }
		public uint Pipe { get; set; }
		public uint ReserveId { get; set; }
		public uint PacketSize { get; set; }
		public uint PacketAlignment { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Execution = ParseWord(reader, end-reader.Position);
		    Pipe = ParseWord(reader, end-reader.Position);
		    ReserveId = ParseWord(reader, end-reader.Position);
		    PacketSize = ParseWord(reader, end-reader.Position);
		    PacketAlignment = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Execution} {Pipe} {ReserveId} {PacketSize} {PacketAlignment}";
        }
    }
}
