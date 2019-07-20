using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSourceExtension: Instruction
    {
        public OpSourceExtension()
        {
        }

        public override Op OpCode { get { return Op.OpSourceExtension; } }

		public string Extension { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Extension = Spv.LiteralString.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Extension}";
        }
    }
}
