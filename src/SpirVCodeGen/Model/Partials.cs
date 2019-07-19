using System;
using System.Collections.Generic;
using System.Text;

namespace SpirVCodeGen.Model
{
    public partial class Enum
    {
        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
    public partial class Instruction
    {
        public override string ToString()
        {
            return opname ?? base.ToString();
        }
    }

    public partial class OperandKind
    {
        public override string ToString()
        {
            return kind ?? base.ToString();
        }

    }
}
