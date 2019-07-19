using System;
using System.Collections.Generic;

namespace SpirVGraph.Spv
{
    public static class IdResultType
    {
	    public static uint Parse(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint? ParseOptional(WordReader reader, uint wordCount)
        {
			if (wordCount == 0) return null;
            return Parse(reader, wordCount);
        }

		public static IList<uint> ParseCollection(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            var res = new List<uint>();
            while (reader.Position < end)
            {
                res.Add(Parse(reader, end-reader.Position));
            }
            return res;
        }
	}
}