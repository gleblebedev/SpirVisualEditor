using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpMemberDecorate: Instruction
    {
        public OpMemberDecorate()
        {
        }

        public override Op OpCode { get { return Op.OpMemberDecorate; } }

		public uint StructureType { get; set; }
		public uint Member { get; set; }
		public Decoration Decoration { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    StructureType = ParseWord(reader, end-reader.Position);
		    Member = ParseWord(reader, end-reader.Position);
		    Decoration = Decoration.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {StructureType} {Member} {Decoration}";
        }
    }
}
