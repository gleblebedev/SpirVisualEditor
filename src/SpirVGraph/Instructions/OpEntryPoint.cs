using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpEntryPoint: Instruction
    {
        public OpEntryPoint()
        {
        }

        public override Op OpCode { get { return Op.OpEntryPoint; } }

		public Spv.ExecutionModel ExecutionModel { get; set; }
		public Spv.IdRef EntryPoint { get; set; }
		public string Name { get; set; }
		public IList<Spv.IdRef> Interface { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("EntryPoint", EntryPoint);
			for (int i=0; i<Interface.Count; ++i)
				yield return new ReferenceProperty("Interface"+i, Interface[i]);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    ExecutionModel = Spv.ExecutionModel.Parse(reader, end-reader.Position);
		    EntryPoint = Spv.IdRef.Parse(reader, end-reader.Position);
		    Name = Spv.LiteralString.Parse(reader, end-reader.Position);
		    Interface = Spv.IdRef.ParseCollection(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {ExecutionModel} {EntryPoint} {Name} {Interface}";
        }
    }
}
