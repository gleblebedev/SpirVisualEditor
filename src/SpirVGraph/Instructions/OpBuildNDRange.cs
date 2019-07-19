using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpBuildNDRange: Instruction
    {
        public OpBuildNDRange()
        {
        }

        public override Op OpCode { get { return Op.OpBuildNDRange; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint GlobalWorkSize { get; set; }
		public uint LocalWorkSize { get; set; }
		public uint GlobalWorkOffset { get; set; }

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
		    GlobalWorkSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    LocalWorkSize = Spv.IdRef.Parse(reader, end-reader.Position);
		    GlobalWorkOffset = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {GlobalWorkSize} {LocalWorkSize} {GlobalWorkOffset}";
        }
    }
}
