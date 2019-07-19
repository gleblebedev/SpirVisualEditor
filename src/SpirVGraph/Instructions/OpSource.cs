using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSource: Instruction
    {
        public OpSource()
        {
        }

        public override Op OpCode { get { return Op.OpSource; } }

		public Spv.SourceLanguage SourceLanguage { get; set; }
		public uint Version { get; set; }
		public uint? File { get; set; }
		public string Source { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    SourceLanguage = Spv.SourceLanguage.Parse(reader, end-reader.Position);
		    Version = Spv.LiteralInteger.Parse(reader, end-reader.Position);
		    File = Spv.IdRef.ParseOptional(reader, end-reader.Position);
		    Source = Spv.LiteralString.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {SourceLanguage} {Version} {File} {Source}";
        }
    }
}
