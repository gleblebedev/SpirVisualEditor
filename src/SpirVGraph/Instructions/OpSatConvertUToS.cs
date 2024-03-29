using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSatConvertUToS: InstructionWithId
    {
        public OpSatConvertUToS()
        {
        }

        public override Op OpCode { get { return Op.OpSatConvertUToS; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef UnsignedValue { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("UnsignedValue", UnsignedValue);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    UnsignedValue = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {UnsignedValue}";
        }
    }
}
