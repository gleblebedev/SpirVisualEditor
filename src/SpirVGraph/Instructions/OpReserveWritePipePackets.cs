using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpReserveWritePipePackets: Instruction
    {
        public OpReserveWritePipePackets()
        {
        }

        public override Op OpCode { get { return Op.OpReserveWritePipePackets; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Pipe { get; set; }
		public uint NumPackets { get; set; }
		public uint PacketSize { get; set; }
		public uint PacketAlignment { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Pipe = ParseWord(reader, end-reader.Position);
		    NumPackets = ParseWord(reader, end-reader.Position);
		    PacketSize = ParseWord(reader, end-reader.Position);
		    PacketAlignment = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Pipe} {NumPackets} {PacketSize} {PacketAlignment}";
        }
    }
}
