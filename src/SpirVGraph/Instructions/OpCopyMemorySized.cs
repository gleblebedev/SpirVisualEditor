using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpCopyMemorySized: Instruction
    {
        public OpCopyMemorySized()
        {
        }

        public override Op OpCode { get { return Op.OpCopyMemorySized; } }

		public uint Target { get; set; }
		public uint Source { get; set; }
		public uint Size { get; set; }
		public Spv.MemoryAccess MemoryAccess { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Target = Spv.IdRef.Parse(reader, end-reader.Position);
		    Source = Spv.IdRef.Parse(reader, end-reader.Position);
		    Size = Spv.IdRef.Parse(reader, end-reader.Position);
		    MemoryAccess = Spv.MemoryAccess.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Target} {Source} {Size} {MemoryAccess}";
        }
    }
}
