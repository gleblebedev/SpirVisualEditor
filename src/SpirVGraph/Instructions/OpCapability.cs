using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpCapability: Instruction
    {
        public OpCapability()
        {
        }

        public override Op OpCode { get { return Op.OpCapability; } }

		public Capability Capability { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Capability = Capability.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Capability}";
        }
    }
}
