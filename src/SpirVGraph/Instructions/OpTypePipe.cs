using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypePipe: TypeInstruction
    {
        public OpTypePipe()
        {
        }

        public override Op OpCode { get { return Op.OpTypePipe; } }

		public Spv.AccessQualifier Qualifier { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Qualifier = Spv.AccessQualifier.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {Qualifier}";
        }
    }
}
