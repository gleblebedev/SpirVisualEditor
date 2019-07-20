using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypeOpaque: TypeInstruction
    {
        public OpTypeOpaque()
        {
        }

        public override Op OpCode { get { return Op.OpTypeOpaque; } }

		public string Thenameoftheopaquetype { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Thenameoftheopaquetype = Spv.LiteralString.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {Thenameoftheopaquetype}";
        }
    }
}
