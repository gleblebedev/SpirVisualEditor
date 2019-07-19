using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeOpaque: Instruction
    {
        public OpTypeOpaque()
        {
        }

        public override Op OpCode { get { return Op.OpTypeOpaque; } }

		public uint IdResult { get; set; }
		public string Thenameoftheopaquetype { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    Thenameoftheopaquetype = ParseString(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {Thenameoftheopaquetype}";
        }
    }
}
