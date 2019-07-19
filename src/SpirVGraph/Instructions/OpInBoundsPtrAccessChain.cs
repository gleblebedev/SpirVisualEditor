using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpInBoundsPtrAccessChain: Instruction
    {
        public OpInBoundsPtrAccessChain()
        {
        }

        public override Op OpCode { get { return Op.OpInBoundsPtrAccessChain; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Base { get; set; }
		public uint Element { get; set; }
		public IList<uint> Indexes { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Base = ParseWord(reader, end-reader.Position);
		    Element = ParseWord(reader, end-reader.Position);
		    Indexes = ParseWordCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Base} {Element} {Indexes}";
        }
    }
}
