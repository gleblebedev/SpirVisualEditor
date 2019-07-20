using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpPhi: InstructionWithId
    {
        public OpPhi()
        {
        }

        public override Op OpCode { get { return Op.OpPhi; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public IList<Spv.PairIdRefIdRef> VariableParent { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    VariableParent = Spv.PairIdRefIdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {VariableParent}";
        }
    }
}
