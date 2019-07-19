using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpVectorInsertDynamic: Instruction
    {
        public OpVectorInsertDynamic()
        {
        }

        public override Op OpCode { get { return Op.OpVectorInsertDynamic; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Vector { get; set; }
		public uint Component { get; set; }
		public uint Index { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    Vector = ParseWord(reader, end-reader.Position);
		    Component = ParseWord(reader, end-reader.Position);
		    Index = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {Vector} {Component} {Index}";
        }
    }
}
