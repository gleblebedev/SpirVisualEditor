using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpStore: Instruction
    {
        public OpStore()
        {
        }

        public override Op OpCode { get { return Op.OpStore; } }

		public uint Pointer { get; set; }
		public uint Object { get; set; }
		public MemoryAccess MemoryAccess { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Pointer = ParseWord(reader, end-reader.Position);
		    Object = ParseWord(reader, end-reader.Position);
		    MemoryAccess = MemoryAccess.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Pointer} {Object} {MemoryAccess}";
        }
    }
}
