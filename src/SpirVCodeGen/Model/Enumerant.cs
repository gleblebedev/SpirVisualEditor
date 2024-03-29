﻿using System.Collections.Generic;

namespace SpirVCodeGen.Model
{
    public class Enumerant
    {
        public string enumerant { get; set; }
        public object value { get; set; }
        public List<string> capabilities { get; set; }
        public List<Parameter> parameters { get; set; }
        public List<string> extensions { get; set; }
    }
}