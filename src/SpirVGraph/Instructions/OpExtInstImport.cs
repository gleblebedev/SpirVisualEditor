using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpExtInstImport: Instruction
    {
        public OpExtInstImport()
        {
        }

        public override Op OpCode { get { return Op.OpExtInstImport; } }

		public uint IdResult { get; set; }
		public string Name { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    Name = ParseString(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResult} {Name}";
        }
    }
}
