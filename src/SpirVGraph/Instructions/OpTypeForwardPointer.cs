using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypeForwardPointer: Instruction
    {
        public OpTypeForwardPointer()
        {
        }

        public override Op OpCode { get { return Op.OpTypeForwardPointer; } }

		public Spv.IdRef PointerType { get; set; }
		public Spv.StorageClass StorageClass { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("PointerType", PointerType);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    PointerType = Spv.IdRef.Parse(reader, end-reader.Position);
		    StorageClass = Spv.StorageClass.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {PointerType} {StorageClass}";
        }
    }
}
