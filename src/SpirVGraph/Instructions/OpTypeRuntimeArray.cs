using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeRuntimeArray: Instruction
    {
        public OpTypeRuntimeArray()
        {
        }

        public override Op OpCode { get { return Op.OpTypeRuntimeArray; } }

		public uint IdResult { get; set; }
		public uint ElementType { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    ElementType = ParseWord(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {ElementType}";
        }
    }
}
