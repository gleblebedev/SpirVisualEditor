using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpGenericCastToPtrExplicit: InstructionWithId
    {
        public OpGenericCastToPtrExplicit()
        {
        }

        public override Op OpCode { get { return Op.OpGenericCastToPtrExplicit; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Pointer { get; set; }
		public Spv.StorageClass Storage { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Pointer", Pointer);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Pointer = Spv.IdRef.Parse(reader, end-reader.Position);
		    Storage = Spv.StorageClass.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Pointer} {Storage}";
        }
    }
}
