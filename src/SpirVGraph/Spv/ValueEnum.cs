using System;
using System.Collections.Generic;
using System.Text;

namespace SpirVGraph.Spv
{
    public abstract class ValueEnum
    {
        protected virtual void PostParse(WordReader reader, uint wordCount)
        {
        }
    }
}
