using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpEmitVertex: Instruction
    {
        public OpEmitVertex()
        {
        }

        public override Op OpCode { get { return Op.OpEmitVertex; } }


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
