using System;
using System.Collections.Generic;

namespace SpirVGraph.Spv
{
    public class PairLiteralIntegerIdRef
    {
	    public uint LiteralInteger { get; set; }
	    public uint IdRef { get; set; }
	    public static PairLiteralIntegerIdRef Parse(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
			var res = new PairLiteralIntegerIdRef();
			res.LiteralInteger = Spv.LiteralInteger.Parse(reader, end-reader.Position);
			res.IdRef = Spv.IdRef.Parse(reader, end-reader.Position);
			return res;
        }

        public static PairLiteralIntegerIdRef ParseOptional(WordReader reader, uint wordCount)
        {
			if (wordCount == 0) return null;
            return Parse(reader, wordCount);
        }

		
        public static IList<PairLiteralIntegerIdRef> ParseCollection(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            var res = new List<PairLiteralIntegerIdRef>();
            while (reader.Position < end)
            {
                res.Add(Parse(reader, end-reader.Position));
            }
            return res;
        }
	}
}