using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpMemberName: Instruction
    {
        public OpMemberName()
        {
        }

        public override Op OpCode { get { return Op.OpMemberName; } }

		public uint Type { get; set; }
		public uint Member { get; set; }
		public string Name { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Type = ParseWord(reader, end-reader.Position);
		    Member = ParseWord(reader, end-reader.Position);
		    Name = ParseString(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Type} {Member} {Name}";
        }
    }
}
