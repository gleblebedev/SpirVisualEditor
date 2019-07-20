using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpMemberName: Instruction
    {
        public OpMemberName()
        {
        }

        public override Op OpCode { get { return Op.OpMemberName; } }

		public Spv.IdRef Type { get; set; }
		public uint Member { get; set; }
		public string Name { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Type", Type);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Type = Spv.IdRef.Parse(reader, end-reader.Position);
		    Member = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    Name = Spv.LiteralString.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Type} {Member} {Name}";
        }
    }
}
