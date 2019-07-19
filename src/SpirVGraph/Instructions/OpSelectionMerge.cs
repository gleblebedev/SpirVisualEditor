using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSelectionMerge: Instruction
    {
        public OpSelectionMerge()
        {
        }

        public override Op OpCode { get { return Op.OpSelectionMerge; } }

		public uint MergeBlock { get; set; }
		public SelectionControl SelectionControl { get; set; }

        public override bool TryGetResultId(out uint id)
        {
			id = 0;
            return false;
        }

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    MergeBlock = ParseWord(reader, end-reader.Position);
		    SelectionControl = SelectionControl.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{OpCode} {MergeBlock} {SelectionControl}";
        }
    }
}
