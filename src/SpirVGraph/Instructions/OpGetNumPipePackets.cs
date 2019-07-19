using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGetNumPipePackets: Instruction
    {
        public OpGetNumPipePackets()
        {
        }

        public override Op OpCode { get { return Op.OpGetNumPipePackets; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Pipe { get; set; }
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
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Pipe = ParseWord(reader, end-reader.Position);
		    PacketSize = ParseWord(reader, end-reader.Position);
		    PacketAlignment = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Pipe} {PacketSize} {PacketAlignment}";
        }
    }
}
