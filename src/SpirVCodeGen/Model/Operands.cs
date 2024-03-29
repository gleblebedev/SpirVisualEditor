﻿using System.Collections.Generic;

namespace SpirVCodeGen.Model
{
    public class Operands
    {
        public List<string> copyright { get; set; }
        public string magic_number { get; set; }
        public int major_version { get; set; }
        public int minor_version { get; set; }
        public int revision { get; set; }
        public List<Instruction> instructions { get; set; }
        public List<OperandKind> operand_kinds { get; set; }
    }
}