using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypePointer: TypeInstruction
    {
        public OpTypePointer()
        {
        }

        public override Op OpCode { get { return Op.OpTypePointer; } }

		public Spv.StorageClass StorageClass { get; set; }
		public Spv.IdRef Type { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Type", Type);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    StorageClass = Spv.StorageClass.Parse(reader, end-reader.Position);
		    Type = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {StorageClass} {Type}";
        }
    }
}
