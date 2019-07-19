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
		public Spv.Decoration Decoration { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    StructType = Spv.IdRef.Parse(reader, end-reader.Position);
		    Member = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    Decoration = Spv.Decoration.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {StructType} {Member} {Decoration}";
        }
    }
}
