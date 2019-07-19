using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpMemberDecorateStringGOOGLE: Instruction
    {
        public OpMemberDecorateStringGOOGLE()
        {
        }

        public override Op OpCode { get { return Op.OpMemberDecorateStringGOOGLE; } }

		public uint StructType { get; set; }
		public uint Member { get; set; }
		public Decoration Decoration { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    StructType = ParseWord(reader, end-reader.Position);
		    Member = ParseWord(reader, end-reader.Position);
		    Decoration = Decoration.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {StructType} {Member} {Decoration}";
        }
    }
}
