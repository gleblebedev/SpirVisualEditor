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

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    ComponentType = ParseWord(reader, end-reader.Position);
		    ComponentCount = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResult} {ComponentType} {ComponentCount}";
        }
    }
}
