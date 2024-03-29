using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpLine: Instruction
    {
        public OpLine()
        {
        }

        public override Op OpCode { get { return Op.OpLine; } }

		public Spv.IdRef File { get; set; }
		public uint Line { get; set; }
		public uint Column { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("File", File);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    File = Spv.IdRef.Parse(reader, end-reader.Position);
		    Line = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    Column = Spv.LiteralInteger.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {File} {Line} {Column}";
        }
    }
}
