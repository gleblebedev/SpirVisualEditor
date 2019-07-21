using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Veldrid;
using Veldrid.SPIRV;

namespace SpirVGraph.Tests
{
    [TestFixture]
    public class ShaderTestFixture
    {
        public static IEnumerable<string> GetEmbeddedShaders()
        {
            foreach (var name in typeof(ShaderTestFixture).Assembly.GetManifestResourceNames())
            {
                if (name.StartsWith("SpirVGraph.Tests.TestShaders"))
                {
                    yield return name;
                }
            }
        }

        [Test]
        [TestCaseSource(nameof(GetEmbeddedShaders))]
        public void LoadSampleShader(string resource)
        {
            string text = null;
            using (var stream = this.GetType().Assembly.GetManifestResourceStream(resource))
            {
                text = new StreamReader(stream).ReadToEnd();
            }

            var stage = ShaderStages.Vertex;
            if (resource.EndsWith(".comp"))
                stage = ShaderStages.Compute;
            if (resource.EndsWith(".vert"))
                stage = ShaderStages.Vertex;
            if (resource.EndsWith(".frag"))
                stage = ShaderStages.Fragment;
            SpirvCompilationResult res;
            try
            {
                res = SpirvCompilation.CompileGlslToSpirv(text, resource, stage, GlslCompileOptions.Default);
            }
            catch (Exception ex)
            {
                Assert.Ignore(ex.Message);
                return;
            }

            var shader = SpirVGraph.Shader.Parse(res.SpirvBytes);
#if DEBUG
            Console.WriteLine(shader);
#endif
        }

        [Test]
        public void DoubleConstant_ParsedCorrectly()
        {
            var res = SpirvCompilation.CompileGlslToSpirv(@"
#version 450

void main()
{
    double x = 12.3;
    gl_Position = vec4(x);
}
", "shader.vert", ShaderStages.Vertex, GlslCompileOptions.Default);
            var shader = SpirVGraph.Shader.Parse(res.SpirvBytes);
#if DEBUG
            Console.WriteLine(shader);
#endif

            var constants = shader.Instructions.Where(_ => _.OpCode == Op.OpConstant).Select(_=>(OpConstant)_).ToList();
            foreach (var instruction in constants)
            {
                if (instruction.Value.Value.Type.OpCode == Op.OpTypeFloat &&
                    instruction.Value.Value.Type.SizeInWords == 2)
                {
                    if (instruction.Value.Value.ToDouble() == 12.3)
                    {
                        return;
                    }
                }
            }
            Assert.Fail("Didn't find Double constant in the shader code:\n"+shader);
        }

        [Test]
        public void FloatConstant_ParsedCorrectly()
        {
            var res = SpirvCompilation.CompileGlslToSpirv(@"
#version 450

void main()
{
    float x = 12.3;
    gl_Position = vec4(x);
}
", "shader.vert", ShaderStages.Vertex, GlslCompileOptions.Default);
            var shader = SpirVGraph.Shader.Parse(res.SpirvBytes);
#if DEBUG
            Console.WriteLine(shader);
#endif

            var constants = shader.Instructions.Where(_ => _.OpCode == Op.OpConstant).Select(_ => (OpConstant)_).ToList();
            foreach (var instruction in constants)
            {
                if (instruction.Value.Value.Type.OpCode == Op.OpTypeFloat &&
                    instruction.Value.Value.Type.SizeInWords == 1)
                {
                    if (instruction.Value.Value.ToFloat() == 12.3f)
                    {
                        return;
                    }
                }
            }
            Assert.Fail("Didn't find float constant in the shader code:\n" + shader);
        }
    }
}
