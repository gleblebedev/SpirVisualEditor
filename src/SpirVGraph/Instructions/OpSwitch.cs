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
		public IList<Spv.PairLiteralIntegerIdRef> Target { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Selector = Spv.IdRef.Parse(reader, end-reader.Position);
		    Default = Spv.IdRef.Parse(reader, end-reader.Position);
		    Target = Spv.PairLiteralIntegerIdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Selector} {Default} {Target}";
        }
    }
}
