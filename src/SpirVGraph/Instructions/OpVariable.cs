using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpVariable: Instruction
    {
        public OpVariable()
        {
        }

        public override Op OpCode { get { return Op.OpVariable; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public StorageClass StorageClass { get; set; }
		public uint? Initializer { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = ParseWord(reader, end-reader.Position);
		    IdResult = ParseWord(reader, end-reader.Position);
		    StorageClass = StorageClass.Parse(reader, end-reader.Position);
		    Initializer = ParseOptionalWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {IdResultType} {IdResult} {StorageClass} {Initializer}";
        }
    }
}
