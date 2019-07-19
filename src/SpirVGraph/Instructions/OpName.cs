using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpName: Instruction
    {
        public OpName()
        {
        }

        public override Op OpCode { get { return Op.OpName; } }

		public uint Target { get; set; }
		public string Name { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Target = ParseWord(reader, end-reader.Position);
		    Name = ParseString(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Target} {Name}";
        }
    }
}
