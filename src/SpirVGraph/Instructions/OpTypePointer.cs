using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypePointer: Instruction
    {
        public OpTypePointer()
        {
        }

        public override Op OpCode { get { return Op.OpTypePointer; } }

		public uint IdResult { get; set; }
		public StorageClass StorageClass { get; set; }
		public uint Type { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    StorageClass = StorageClass.Parse(reader, end-reader.Position);
		    Type = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResult} {StorageClass} {Type}";
        }
    }
}
