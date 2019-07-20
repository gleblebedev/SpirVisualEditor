using System;
using System.Collections.Generic;

namespace SpirVGraph.Spv
{
    public class KernelProfilingInfo : ValueEnum
    {
		[Flags]
        public enum Enumerant
        {
            None = 0x0000,
            [Capability(Capability.Enumerant.Kernel)]
            CmdExecTime = 0x0001,
		}

        public KernelProfilingInfo(Enumerant value)
        {
            Value = value;
        }

        public Enumerant Value { get; }

        public static KernelProfilingInfo Parse(WordReader reader, uint wordCount)
        {
            var id = (Enumerant) reader.ReadWord();
			return new KernelProfilingInfo(id);
        }

        public static KernelProfilingInfo ParseOptional(WordReader reader, uint wordCount)
        {
			if (wordCount == 0) return null;
            return Parse(reader, wordCount);
        }

        public static IList<KernelProfilingInfo> ParseCollection(WordReader reader, uint wordCount)
        {
            var end = reader.Position + wordCount;
            var res = new PrintableList<KernelProfilingInfo>();
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