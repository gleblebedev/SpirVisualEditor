using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpVectorInsertDynamic: InstructionWithId
    {
        public OpVectorInsertDynamic()
        {
        }

        public override Op OpCode { get { return Op.OpVectorInsertDynamic; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Vector { get; set; }
		public Spv.IdRef Component { get; set; }
		public Spv.IdRef Index { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Vector", Vector);
		    yield return new ReferenceProperty("Component", Component);
		    yield return new ReferenceProperty("Index", Index);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Vector = Spv.IdRef.Parse(reader, end-reader.Position);
		    Component = Spv.IdRef.Parse(reader, end-reader.Position);
		    Index = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Vector} {Component} {Index}";
        }
    }
}
