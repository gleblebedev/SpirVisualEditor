﻿using System.Collections.Generic;

namespace SpirVCodeGen.Model
{
    public partial class Instruction
    {
        public string opname { get; set; }
        public int opcode { get; set; }
        public List<Operand> operands { get; set; }
        public List<string> capabilities { get; set; }
        public List<string> extensions { get; set; }
    }
}