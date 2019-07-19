using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpEntryPoint: Instruction
    {
        public OpEntryPoint()
        {
        }

        public override Op OpCode { get { return Op.OpEntryPoint; } }

		public ExecutionModel ExecutionModel { get; set; }
		public uint EntryPoint { get; set; }
		public string Name { get; set; }
		public IList<uint> Interface { get; set; }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    ExecutionModel = ExecutionModel.Parse(reader, end-reader.Position);
		    EntryPoint = ParseWord(reader, end-reader.Position);
		    Name = ParseString(reader, end-reader.Position);
		    Interface = ParseWordCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {ExecutionModel} {EntryPoint} {Name} {Interface}";
        }
    }
}
