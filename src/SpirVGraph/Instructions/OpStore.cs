using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpStore: Instruction
    {
        public OpStore()
        {
        }

        public override Op OpCode { get { return Op.OpStore; } }

		public Spv.IdRef Pointer { get; set; }
		public Spv.IdRef Object { get; set; }
		public Spv.MemoryAccess MemoryAccess { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Pointer", Pointer);
		    yield return new ReferenceProperty("Object", Object);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Pointer = Spv.IdRef.Parse(reader, end-reader.Position);
		    Object = Spv.IdRef.Parse(reader, end-reader.Position);
		    MemoryAccess = Spv.MemoryAccess.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Pointer} {Object} {MemoryAccess}";
        }
    }
}
