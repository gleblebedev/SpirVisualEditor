using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpReturnValue: Instruction
    {
        public OpReturnValue()
        {
        }

        public override Op OpCode { get { return Op.OpReturnValue; } }

		public uint Value { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Value = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Value}";
        }
    }
}
