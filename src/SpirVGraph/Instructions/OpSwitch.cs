using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSwitch: Instruction
    {
        public OpSwitch()
        {
        }

        public override Op OpCode { get { return Op.OpSwitch; } }

		public uint Selector { get; set; }
		public uint Default { get; set; }
		public IList<IdAndLiteral> Target { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Selector = ParseWord(reader, end-reader.Position);
		    Default = ParseWord(reader, end-reader.Position);
		    Target = ParsePairLiteralIntegerIdRefCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Selector} {Default} {Target}";
        }
    }
}
