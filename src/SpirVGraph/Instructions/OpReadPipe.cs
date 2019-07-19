using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpReadPipe: Instruction
    {
        public OpReadPipe()
        {
        }

        public override Op OpCode { get { return Op.OpReadPipe; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Pipe { get; set; }
		public uint Pointer { get; set; }
		public uint PacketSize { get; set; }
		public uint PacketAlignment { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Pipe = ParseWord(reader, end-reader.Position);
		    Pointer = ParseWord(reader, end-reader.Position);
		    PacketSize = ParseWord(reader, end-reader.Position);
		    PacketAlignment = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Pipe} {Pointer} {PacketSize} {PacketAlignment}";
        }
    }
}
