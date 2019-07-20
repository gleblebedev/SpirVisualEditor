using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpSelectionMerge: Instruction
    {
        public OpSelectionMerge()
        {
        }

        public override Op OpCode { get { return Op.OpSelectionMerge; } }

		public Spv.IdRef MergeBlock { get; set; }
		public Spv.SelectionControl SelectionControl { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("MergeBlock", MergeBlock);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    MergeBlock = Spv.IdRef.Parse(reader, end-reader.Position);
		    SelectionControl = Spv.SelectionControl.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {MergeBlock} {SelectionControl}";
        }
    }
}
