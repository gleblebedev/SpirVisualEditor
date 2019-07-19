using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpTypeFunction: Instruction
    {
        public OpTypeFunction()
        {
        }

        public override Op OpCode { get { return Op.OpTypeFunction; } }

		public uint IdResult { get; set; }
		public uint ReturnType { get; set; }
		public IList<uint> ParameterTypes { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = IdResult;
            return true;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
		    ReturnType = Spv.IdRef.Parse(reader, end-reader.Position);
		    ParameterTypes = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {ReturnType} {ParameterTypes}";
        }
    }
}
