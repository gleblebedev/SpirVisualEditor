using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSourceContinued: Instruction
    {
        public OpSourceContinued()
        {
        }

        public override Op OpCode { get { return Op.OpSourceContinued; } }

		public string ContinuedSource { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    ContinuedSource = Spv.LiteralString.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {ContinuedSource}";
        }
    }
}
