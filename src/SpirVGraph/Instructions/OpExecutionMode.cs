using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpExecutionMode: Instruction
    {
        public OpExecutionMode()
        {
        }

        public override Op OpCode { get { return Op.OpExecutionMode; } }

		public Spv.IdRef EntryPoint { get; set; }
		public Spv.ExecutionMode Mode { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("EntryPoint", EntryPoint);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    EntryPoint = Spv.IdRef.Parse(reader, end-reader.Position);
		    Mode = Spv.ExecutionMode.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {EntryPoint} {Mode}";
        }
    }
}
