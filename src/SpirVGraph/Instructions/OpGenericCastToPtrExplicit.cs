using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpGenericCastToPtrExplicit: Instruction
    {
        public OpGenericCastToPtrExplicit()
        {
        }

        public override Op OpCode { get { return Op.OpGenericCastToPtrExplicit; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Pointer { get; set; }
		public Spv.StorageClass Storage { get; set; }

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
		    Pointer = Spv.IdRef.Parse(reader, end-reader.Position);
		    Storage = Spv.StorageClass.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Pointer} {Storage}";
        }
    }
}
