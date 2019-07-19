using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypePipe: Instruction
    {
        public OpTypePipe()
        {
        }

        public override Op OpCode { get { return Op.OpTypePipe; } }

		public uint IdResult { get; set; }
		public AccessQualifier Qualifier { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    Qualifier = AccessQualifier.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResult} {Qualifier}";
        }
    }
}
