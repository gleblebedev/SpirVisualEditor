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
		public Spv.StorageClass StorageClass { get; set; }
		public uint? Initializer { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    StorageClass = Spv.StorageClass.Parse(reader, end-reader.Position);
		    Initializer = Spv.IdRef.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {StorageClass} {Initializer}";
        }
    }
}
