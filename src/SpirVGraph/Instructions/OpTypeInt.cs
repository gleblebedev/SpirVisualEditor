using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypeInt: TypeInstruction
    {
        public OpTypeInt()
        {
        }

        public override Op OpCode { get { return Op.OpTypeInt; } }

		public uint Width { get; set; }
		public uint Signedness { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Width = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    Signedness = Spv.LiteralInteger.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {Width} {Signedness}";
        }
    }
}
