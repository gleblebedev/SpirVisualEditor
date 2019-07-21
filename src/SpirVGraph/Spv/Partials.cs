namespace SpirVGraph.Spv
{
    public partial class ImageOperands
    {
        public IdRef Bias { get; set; }
        public IdRef Lod { get; set; }
        public IdRef Grad { get; set; }
        public IdRef ConstOffset { get; set; }
        public IdRef Offset { get; set; }
        public IdRef ConstOffsets { get; set; }
        public IdRef Sample { get; set; }
        public IdRef MinLod { get; set; }

        protected virtual void PostParse(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            if (Enumerant.Bias == (Value & Enumerant.Bias))
                Bias = IdRef.Parse(reader, end - reader.Position);
            if (Enumerant.Lod == (Value & Enumerant.Lod))
                Lod = IdRef.Parse(reader, end - reader.Position);
            if (Enumerant.Grad == (Value & Enumerant.Grad))
                Grad = IdRef.Parse(reader, end - reader.Position);
            if (Enumerant.ConstOffset == (Value & Enumerant.ConstOffset))
                ConstOffset = IdRef.Parse(reader, end - reader.Position);
            if (Enumerant.Offset == (Value & Enumerant.Offset))
                Offset = IdRef.Parse(reader, end - reader.Position);
            if (Enumerant.ConstOffsets == (Value & Enumerant.ConstOffsets))
                ConstOffsets = IdRef.Parse(reader, end - reader.Position);
            if (Enumerant.ConstOffsets == (Value & Enumerant.ConstOffsets))
                ConstOffsets = IdRef.Parse(reader, end - reader.Position);
            if (Enumerant.Sample == (Value & Enumerant.Sample))
                Sample = IdRef.Parse(reader, end - reader.Position);
            if (Enumerant.MinLod == (Value & Enumerant.MinLod))
                MinLod = IdRef.Parse(reader, end - reader.Position);
        }

    }
}