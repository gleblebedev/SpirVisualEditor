using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeStruct: Instruction
    {
        public OpTypeStruct()
        {
        }

        public override Op OpCode { get { return Op.OpTypeStruct; } }

		public uint IdResult { get; set; }
		public IList<uint> MemberTypes { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = ParseWord(reader, end-reader.Position);
		    MemberTypes = ParseWordCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {MemberTypes}";
        }
    }
}
