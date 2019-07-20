using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpGroupMemberDecorate: Instruction
    {
        public OpGroupMemberDecorate()
        {
        }

        public override Op OpCode { get { return Op.OpGroupMemberDecorate; } }

		public Spv.IdRef DecorationGroup { get; set; }
		public IList<Spv.PairIdRefLiteralInteger> Targets { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("DecorationGroup", DecorationGroup);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    DecorationGroup = Spv.IdRef.Parse(reader, end-reader.Position);
		    Targets = Spv.PairIdRefLiteralInteger.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {DecorationGroup} {Targets}";
        }
    }
}
