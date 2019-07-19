using System.Collections.Generic;

namespace SpirVCodeGen.Model
{
    public partial class Enum
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Dictionary<string,int> Values { get; set; }
    }
}