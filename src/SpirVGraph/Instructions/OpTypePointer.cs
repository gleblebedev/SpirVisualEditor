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
		public Spv.StorageClass StorageClass { get; set; }
		public uint Type { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    StorageClass = Spv.StorageClass.Parse(reader, end-reader.Position);
		    Type = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {StorageClass} {Type}";
        }
    }
}
