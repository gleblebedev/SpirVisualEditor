using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpExtInst: Instruction
    {
        public OpExtInst()
        {
        }

        public override Op OpCode { get { return Op.OpExtInst; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Set { get; set; }
		public uint Instruction { get; set; }
		public IList<uint> Operands { get; set; }

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
		    Set = Spv.IdRef.Parse(reader, end-reader.Position);
		    Instruction = Spv.LiteralExtInstInteger.Parse(reader, end-reader.Position);
		    Operands = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Set} {Instruction} {Operands}";
        }
    }
}
