using System.Collections.Generic;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public abstract  class Instruction
    {
        public virtual bool TryGetResultId(out uint id)
        {
            id = 0;
            return false;
        }

        public abstract Op OpCode { get; }

        public virtual IEnumerable<ReferenceProperty> GetReferences()
        {
            yield break;
        }

        public virtual void Parse(WordReader reader, uint wordCount)
        {
            for (uint i = 1; i < wordCount; ++i)
            {
                reader.ReadWord();
            }
        }

        public override string ToString()
        {
            return OpCode.ToString();
        }
    }
}