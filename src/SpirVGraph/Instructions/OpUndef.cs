using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpUndef: InstructionWithId
    {
        public OpUndef()
        {
        }

        public override Op OpCode { get { return Op.OpUndef; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
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
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} ";
        }
    }
}
