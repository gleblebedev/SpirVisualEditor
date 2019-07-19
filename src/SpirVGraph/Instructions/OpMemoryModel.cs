using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpMemoryModel: Instruction
    {
        public OpMemoryModel()
        {
        }

        public override Op OpCode { get { return Op.OpMemoryModel; } }

		public AddressingModel AddressingModel { get; set; }
		public MemoryModel MemoryModel { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    AddressingModel = AddressingModel.Parse(reader, end-reader.Position);
		    MemoryModel = MemoryModel.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {AddressingModel} {MemoryModel}";
        }
    }
}
