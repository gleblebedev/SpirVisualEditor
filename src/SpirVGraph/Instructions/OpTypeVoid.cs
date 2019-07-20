using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypeVoid: TypeInstruction
    {
        public OpTypeVoid()
        {
        }

        public override Op OpCode { get { return Op.OpTypeVoid; } }

        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} ";
        }
    }
}
