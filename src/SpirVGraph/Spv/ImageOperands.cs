using System;
using System.Collections.Generic;

namespace SpirVGraph.Spv
{
    public class ImageOperands : ValueEnum
    {
		[Flags]
        public enum Enumerant
        {
            None = 0x0000,
            [Capability(Capability.Enumerant.Shader)]
            Bias = 0x0001,
            Lod = 0x0002,
            Grad = 0x0004,
            ConstOffset = 0x0008,
            [Capability(Capability.Enumerant.ImageGatherExtended)]
            Offset = 0x0010,
            ConstOffsets = 0x0020,
            Sample = 0x0040,
            [Capability(Capability.Enumerant.MinLod)]
            MinLod = 0x0080,
		}

        public ImageOperands(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static ImageOperands Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
			return new ImageOperands(id);
        }

        public static ImageOperands ParseOptional(WordReader reader, uint wordCount)
        {
			if (wordCount == 0) return null;
            return Parse(reader, wordCount);
        }

        public static IList<ImageOperands> ParseCollection(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            var res = new List<ImageOperands>();
            while (reader.Position < end)
            {
                res.Add(Parse(reader, end-reader.Position));
            }
            return res;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}