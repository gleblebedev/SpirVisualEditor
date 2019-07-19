using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGroupReserveReadPipePackets: Instruction
    {
        public OpGroupReserveReadPipePackets()
        {
        }

        public override Op OpCode { get { return Op.OpGroupReserveReadPipePackets; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Execution { get; set; }
		public uint Pipe { get; set; }
		public uint NumPackets { get; set; }
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
		    Execution = Spv.IdScope.Parse(reader, end-reader.Position);
		    Pipe = Spv.IdRef.Parse(reader, end-reader.Position);
		    NumPackets = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    PacketAlignment = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Execution} {Pipe} {NumPackets} {PacketSize} {PacketAlignment}";
        }
    }
}
