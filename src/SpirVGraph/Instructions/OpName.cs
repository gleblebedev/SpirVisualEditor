using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpName: Instruction
    {
        public OpName()
        {
        }

        public override Op OpCode { get { return Op.OpName; } }

		public Spv.IdRef Target { get; set; }
		public string Name { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Target", Target);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Target = Spv.IdRef.Parse(reader, end-reader.Position);
		    Name = Spv.LiteralString.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Target} {Name}";
        }
    }
}
