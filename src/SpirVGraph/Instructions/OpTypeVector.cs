using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypeVector: TypeInstruction
    {
        public OpTypeVector()
        {
        }

        public override Op OpCode { get { return Op.OpTypeVector; } }

		public Spv.IdRef ComponentType { get; set; }
		public uint ComponentCount { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("ComponentType", ComponentType);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    ComponentType = Spv.IdRef.Parse(reader, end-reader.Position);
		    ComponentCount = Spv.LiteralInteger.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {ComponentType} {ComponentCount}";
        }
    }
}
