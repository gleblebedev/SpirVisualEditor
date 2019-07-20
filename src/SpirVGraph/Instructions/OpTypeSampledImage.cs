using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypeSampledImage: TypeInstruction
    {
        public OpTypeSampledImage()
        {
        }

        public override Op OpCode { get { return Op.OpTypeSampledImage; } }

		public Spv.IdRef ImageType { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("ImageType", ImageType);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    ImageType = Spv.IdRef.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {ImageType}";
        }
    }
}
