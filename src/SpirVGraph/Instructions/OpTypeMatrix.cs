using System.Collections.Generic;
using SpirVGraph.Spv;


namespace SpirVGraph.Instructions
{
    public partial class OpTypeMatrix: TypeInstruction
    {
        public OpTypeMatrix()
        {
        }

        public override Op OpCode { get { return Op.OpTypeMatrix; } }

		public Spv.IdRef ColumnType { get; set; }
		public uint ColumnCount { get; set; }
        public override IEnumerable<ReferenceProperty> GetReferences()
		{
		    yield return new ReferenceProperty("ColumnType", ColumnType);
		    yield break;
		}

        public override void Parse(WordReader reader, uint wordCount)
        {
			var end = reader.Position+wordCount-1;
		    IdResult = Spv.IdResult.Parse(reader, end-reader.Position);
            reader.Instructions.Add(this);
		    ColumnType = Spv.IdRef.Parse(reader, end-reader.Position);
		    ColumnCount = Spv.LiteralInteger.Parse(reader, end-reader.Position);
        }

        public override string ToString()
        {
            return $"{IdResult} = {OpCode} {ColumnType} {ColumnCount}";
        }
    }
}
