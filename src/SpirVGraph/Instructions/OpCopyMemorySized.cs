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
		public MemoryAccess MemoryAccess { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Target = ParseWord(reader, end-reader.Position);
		    Source = ParseWord(reader, end-reader.Position);
		    Size = ParseWord(reader, end-reader.Position);
		    MemoryAccess = MemoryAccess.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Target} {Source} {Size} {MemoryAccess}";
        }
    }
}
