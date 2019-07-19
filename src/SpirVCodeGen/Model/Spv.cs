using System.Collections.Generic;

namespace SpirVCodeGen.Model
{
    public class Spv
    {
        public Meta meta { get; set; }
        public List<Enum> @enum { get; set; }
    }
}