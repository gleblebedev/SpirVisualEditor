using System;
using System.Collections.Generic;
using System.Text;

namespace SpirVGraph.Spv
{
    public enum SpvSourceLanguage
    {
        Unknown = 0,
        ESSL = 1,
        GLSL = 2,
        OpenCL_C = 3,
        OpenCL_CPP = 4,
        HLSL = 5,
        Max = 0x7fffffff,
    }
}
