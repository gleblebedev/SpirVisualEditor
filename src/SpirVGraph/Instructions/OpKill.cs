using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpKill: Instruction
    {
        public OpKill()
        {
        }

        public override Op OpCode { get { return Op.OpKill; } }

        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
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
