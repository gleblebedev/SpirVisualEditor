using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpImageRead: InstructionWithId
    {
        public OpImageRead()
        {
        }

        public override Op OpCode { get { return Op.OpImageRead; } }

		public Spv.IdRef<TypeInstruction> IdResultType { get; set; }
		public Spv.IdRef Image { get; set; }
		public Spv.IdRef Coordinate { get; set; }
		public Spv.ImageOperands ImageOperands { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("Image", Image);
		    yield return new ReferenceProperty("Coordinate", Coordinate);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResultType = Spv.IdResultType.Parse(reader, end-reader.Position);
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    Image = Spv.IdRef.Parse(reader, end-reader.Position);
		    Coordinate = Spv.IdRef.Parse(reader, end-reader.Position);
		    ImageOperands = Spv.ImageOperands.ParseOptional(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResultType} {IdResult} = {OpCode} {Image} {Coordinate} {ImageOperands}";
        }
    }
}
