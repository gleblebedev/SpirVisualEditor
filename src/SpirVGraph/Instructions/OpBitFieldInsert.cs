using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpBitFieldInsert: Instruction
    {
        public OpBitFieldInsert()
        {
        }

        public override Op OpCode { get { return Op.OpBitFieldInsert; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Base { get; set; }
		public uint Insert { get; set; }
		public uint Offset { get; set; }
		public uint Count { get; set; }

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
		    Base = Spv.IdRef.Parse(reader, end-reader.Position);
		    Insert = Spv.IdRef.Parse(reader, end-reader.Position);
		    Offset = Spv.IdRef.Parse(reader, end-reader.Position);
		    Count = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Base} {Insert} {Offset} {Count}";
        }
    }
}
