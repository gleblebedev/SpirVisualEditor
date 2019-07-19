using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpReturn: Instruction
    {
        public OpReturn()
        {
        }

        public override Op OpCode { get { return Op.OpReturn; } }


        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
        }

        public override string ToString()
        {
            return $"{OpCode} ";
        }
    }
}
