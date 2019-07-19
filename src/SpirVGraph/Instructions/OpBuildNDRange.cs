using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpBuildNDRange: Instruction
    {
        public OpBuildNDRange()
        {
        }

        public override Op OpCode { get { return Op.OpBuildNDRange; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint GlobalWorkSize { get; set; }
		public uint LocalWorkSize { get; set; }
		public uint GlobalWorkOffset { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    GlobalWorkSize = ParseWord(reader, end-reader.Position);
		    LocalWorkSize = ParseWord(reader, end-reader.Position);
		    GlobalWorkOffset = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {GlobalWorkSize} {LocalWorkSize} {GlobalWorkOffset}";
        }
    }
}
