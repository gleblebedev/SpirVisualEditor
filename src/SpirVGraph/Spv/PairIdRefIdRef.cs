using System;
using System.Collections.Generic;
using SpirVGraph.Instructions;

namespace SpirVGraph.Spv
{
    public class PairIdRefIdRef
    {
	    public Spv.IdRef IdRef { get; set; }
	    public Spv.IdRef IdRef2 { get; set; }
	    public static PairIdRefIdRef Parse(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
			var res = new PairIdRefIdRef();
			res.IdRef = Spv.IdRef.Parse(reader, end-reader.Position);
			res.IdRef2 = Spv.IdRef.Parse(reader, end-reader.Position);
			return res;
        }

        public static PairIdRefIdRef ParseOptional(WordReader reader, uint wordCount)
        {
			if (wordCount == 0) return null;
            return Parse(reader, wordCount);
        }

		
        public static IList<PairIdRefIdRef> ParseCollection(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            var res = new PrintableList<PairIdRefIdRef>();
            while (reader.Position < end)
            {
                res.Add(Parse(reader, end-reader.Position));
            }
            return res;
        }
	}
}