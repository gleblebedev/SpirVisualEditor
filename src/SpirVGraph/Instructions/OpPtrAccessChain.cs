using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpPtrAccessChain: Instruction
    {
        public OpPtrAccessChain()
        {
        }

        public override Op OpCode { get { return Op.OpPtrAccessChain; } }

		public uint IdResultType { get; set; }
		public uint IdResult { get; set; }
		public uint Base { get; set; }
		public uint Element { get; set; }
		public IList<uint> Indexes { get; set; }

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
		    Base = Spv.IdRef.Parse(reader, end-reader.Position);
		    Element = Spv.IdRef.Parse(reader, end-reader.Position);
		    Indexes = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Base} {Element} {Indexes}";
        }
    }
}
