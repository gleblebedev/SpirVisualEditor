using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpMemoryModel: Instruction
    {
        public OpMemoryModel()
        {
        }

        public override Op OpCode { get { return Op.OpMemoryModel; } }

		public Spv.AddressingModel AddressingModel { get; set; }
		public Spv.MemoryModel MemoryModel { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    AddressingModel = Spv.AddressingModel.Parse(reader, end-reader.Position);
		    MemoryModel = Spv.MemoryModel.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {AddressingModel} {MemoryModel}";
        }
    }
}
