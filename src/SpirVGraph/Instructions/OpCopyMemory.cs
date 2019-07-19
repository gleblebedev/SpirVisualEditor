using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpCopyMemory: Instruction
    {
        public OpCopyMemory()
        {
        }

        public override Op OpCode { get { return Op.OpCopyMemory; } }

		public uint Target { get; set; }
		public uint Source { get; set; }
		public MemoryAccess MemoryAccess { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Target = ParseWord(reader, end-reader.Position);
		    Source = ParseWord(reader, end-reader.Position);
		    MemoryAccess = MemoryAccess.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Target} {Source} {MemoryAccess}";
        }
    }
}
