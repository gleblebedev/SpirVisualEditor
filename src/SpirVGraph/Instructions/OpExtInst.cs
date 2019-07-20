using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpExtInst: InstructionWithId
    {
        public OpExtInst()
        {
        }

        public override Op OpCode { get { return Op.OpExtInst; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Set { get; set; }
		public uint Instruction { get; set; }
		public IList<Spv.IdRef> Operands { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Set", Set);
			for (int i=0; i<Operands.Count; ++i)
				yield return new ReferenceProperty("Operands"+i, Operands[i]);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Set = Spv.IdRef.Parse(reader, end-reader.Position);
		    Instruction = Spv.LiteralExtInstInteger.Parse(reader, end-reader.Position);
		    Operands = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Set} {Instruction} {Operands}";
        }
    }
}
