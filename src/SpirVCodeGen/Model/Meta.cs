using System;
using System.Collections.Generic;
using System.Text;

namespace SpirVCodeGen.Model
{
    public class Meta
    {
        public List<List<string>> Comment { get; set; }
        public int MagicNumber { get; set; }
        public int Version { get; set; }
        public int Revision { get; set; }
        public int OpCodeMask { get; set; }
        public int WordCountShift { get; set; }
    }
}
