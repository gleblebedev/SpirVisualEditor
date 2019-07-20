using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpLifetimeStart: Instruction
    {
        public OpLifetimeStart()
        {
        }

        public override Op OpCode { get { return Op.OpLifetimeStart; } }

		public Spv.IdRef Pointer { get; set; }
		public uint Size { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Pointer", Pointer);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    Pointer = Spv.IdRef.Parse(reader, end-reader.Position);
		    Size = Spv.LiteralInteger.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {Pointer} {Size}";
        }
    }
}
