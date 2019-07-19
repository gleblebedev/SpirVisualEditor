using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeVector: Instruction
    {
        public OpTypeVector()
        {
        }

        public override Op OpCode { get { return Op.OpTypeVector; } }

		public uint IdResult { get; set; }
		public uint ComponentType { get; set; }
		public uint ComponentCount { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    ComponentType = Spv.IdRef.Parse(reader, end-reader.Position);
		    ComponentCount = Spv.LiteralInteger.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {ComponentType} {ComponentCount}";
        }
    }
}
