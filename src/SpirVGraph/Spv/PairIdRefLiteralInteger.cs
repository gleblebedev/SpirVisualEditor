using System;
using System.Collections.Generic;
using SpirVGraph.Instructions;

namespace SpirVGraph.Spv
{
    public class PairIdRefLiteralInteger
    {
	    public Spv.IdRef IdRef { get; set; }
	    public uint LiteralInteger { get; set; }
	    public static PairIdRefLiteralInteger Parse(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
			var res = new PairIdRefLiteralInteger();
			res.IdRef = Spv.IdRef.Parse(reader, end-reader.Position);
			res.LiteralInteger = Spv.LiteralInteger.Parse(reader, end-reader.Position);
			return res;
        }

        public static PairIdRefLiteralInteger ParseOptional(WordReader reader, uint wordCount)
        {
			if (wordCount == 0) return null;
            return Parse(reader, wordCount);
        }

		
        public static IList<PairIdRefLiteralInteger> ParseCollection(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            var res = new PrintableList<PairIdRefLiteralInteger>();
            while (reader.Position < end)
            {
                res.Add(Parse(reader, end-reader.Position));
            }
            return res;
        }
	}
}