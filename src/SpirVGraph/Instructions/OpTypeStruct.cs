using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypeStruct: TypeInstruction
    {
        public OpTypeStruct()
        {
        }

        public override Op OpCode { get { return Op.OpTypeStruct; } }

		public IList<Spv.IdRef> MemberTypes { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
			for (int i=0; i<MemberTypes.Count; ++i)
				yield return new ReferenceProperty("MemberTypes"+i, MemberTypes[i]);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    MemberTypes = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {MemberTypes}";
        }
    }
}
