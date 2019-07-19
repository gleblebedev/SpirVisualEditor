using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpExtension: Instruction
    {
        public OpExtension()
        {
        }

        public override Op OpCode { get { return Op.OpExtension; } }

		public string Name { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Name = ParseString(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Name}";
        }
    }
}
