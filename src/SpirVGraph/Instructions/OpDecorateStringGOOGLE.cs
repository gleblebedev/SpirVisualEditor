using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpDecorateStringGOOGLE: Instruction
    {
        public OpDecorateStringGOOGLE()
        {
        }

        public override Op OpCode { get { return Op.OpDecorateStringGOOGLE; } }

		public uint Target { get; set; }
		public Decoration Decoration { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Target = ParseWord(reader, end-reader.Position);
		    Decoration = Decoration.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Target} {Decoration}";
        }
    }
}
