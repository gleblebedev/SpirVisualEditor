using System;
using NUnit.Framework;
using Veldrid;
using Veldrid.SPIRV;

namespace SpirVGraph.Tests
{
    [TestFixture]
    public class ShaderTestFixture
    {
        [Test]
        public void SimpleVertexShader()
        {
            var res = SpirvCompilation.CompileGlslToSpirv(@"
#version 450

layout(location = 0) in vec3 POSITION;

void main()
{
    gl_Position = vec4(POSITION, 1.0f);
}
", "shader.vert", ShaderStages.Vertex, GlslCompileOptions.Default);
            var shader = SpirVGraph.Shader.Parse(res.SpirvBytes);

            Console.WriteLine(shader);
        }
    }
}
