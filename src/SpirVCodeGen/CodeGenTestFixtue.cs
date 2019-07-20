using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using NUnit.Framework;
using SpirVCodeGen.Model;
using Enum = SpirVCodeGen.Model.Enum;

namespace SpirVCodeGen
{
    [TestFixture]
    public class CodeGenTestFixtue
    {
        public static IEnumerable<Instruction> GetInstructions()
        {
            using (var stream = typeof(CodeGenTestFixtue).Assembly.GetManifestResourceStream(
                typeof(CodeGenTestFixtue).Namespace + ".spirv.core.grammar.json"))
            {
                var enums = JsonConvert.DeserializeObject<Operands>(new StreamReader(stream).ReadToEnd());
                foreach (var instruction in enums.instructions)
                {
                    yield return instruction;
                }
            }
        }
        public static IEnumerable<OperandKind> GetOperandKinds()
        {
            using (var stream = typeof(CodeGenTestFixtue).Assembly.GetManifestResourceStream(
                typeof(CodeGenTestFixtue).Namespace + ".spirv.core.grammar.json"))
            {
                var enums = JsonConvert.DeserializeObject<Operands>(new StreamReader(stream).ReadToEnd());
                foreach (var operandKind in enums.operand_kinds)
                {
                    yield return operandKind;
                }
            }
        }


        [Test]
        [TestCaseSource(nameof(GetOperandKinds))]
        public void GenerateOperandKindFile(SpirVCodeGen.Model.OperandKind operandKind)
        {
            var path = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location),
                @"..\..\..\..\SpirVGraph\Spv\" + operandKind.kind + ".cs");
            string text = null;
            if (operandKind.category == "ValueEnum")
            {
                text = new EnumTemplate(operandKind).TransformText();
            }
            else if (operandKind.category == "BitEnum")
            {
                text = new FlagTemplate(operandKind).TransformText();
            }
            //else if (operandKind.category == "Id")
            //{
            //    text = new IdTemplate(operandKind).TransformText();
            //}
            else if (operandKind.category == "Composite")
            {
                text = new CompositeTemplate(operandKind).TransformText();
            }
            //else if (operandKind.category == "Literal")
            //{
            //    text = new LiteralTemplate(operandKind).TransformText();
            //}
            else
            {
                Assert.Ignore(operandKind.category + " not implemented yet.");
            }

            if (text == null)
            {
                Assert.Ignore(operandKind.category + " not implemented yet.");
            }
            using (var file = File.CreateText(path))
            {
                file.Write(text);
            }
        }

        [Test]
        public void GetAllInstructions()
        {
            foreach (var instruction in GetInstructions())
            {
                var refs = (instruction.operands ?? EmptyReadOnlyList<Operand>.Instance).Where(_ => _.kind == "IdRef" && string.IsNullOrWhiteSpace(_.quantifier)).ToList();
                if (refs.Count > 0)
                {
                    Console.WriteLine("                    case Op."+ instruction.opname+ ": {");
                    Console.WriteLine("                        var i = (" + instruction.opname + ") instruction;");
                    foreach (var operand in refs)
                    {
                        Console.WriteLine("                        Connect(i."+Utils.GetOperandName(operand) +", node, \"" + Utils.GetOperandName(operand) + "\");");
                    }
                    Console.WriteLine("                        break; }");
                }
            }
        }

        [Test]
        public void GetAllFlags()
        {
            foreach (var category in GetOperandKinds().ToLookup(_ => _.category))
            {
                Console.WriteLine("public static bool Is"+category.Key+"(string kind)");
                Console.WriteLine("{");
                Console.WriteLine("switch (kind)");
                Console.WriteLine("{");
                foreach (var kind in category)
                {
                    Console.WriteLine("case \""+kind+"\":");
                }
                Console.WriteLine("return true;");
                Console.WriteLine("}");
                Console.WriteLine("return false;");
                Console.WriteLine("}");
            }
        }

        [Test]
        [TestCaseSource(nameof(GetInstructions))]
        public void GenerateInstructionFile(SpirVCodeGen.Model.Instruction instruction)
        {
            var path = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location),
                @"..\..\..\..\SpirVGraph\Instructions\" + instruction.opname + ".cs");
            var text = new InstructionTemplate(instruction).TransformText();
            using (var file = File.CreateText(path))
            {
                file.Write(text);
            }
        }

        [Test]
        [TestCaseSource(nameof(GetInstructions))]
        public void GenerateInstructionNodeFactoryFile(SpirVCodeGen.Model.Instruction instruction)
        {
            var path = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location),
                @"..\..\..\..\SpirVGraph\NodeFactories\" + instruction.opname + "NodeFactory.cs");
            var text = new NodeFactoryTemplate(instruction).TransformText();
            using (var file = File.CreateText(path))
            {
                file.Write(text);
            }
        }

        [Test]
        public void GenerateInstructionFactoryFile()
        {
            var path = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location),
                @"..\..\..\..\SpirVGraph\Instructions\InstructionFacotry.cs");
            using (var file = File.CreateText(path))
            {
                file.Write(new InstructionFactoryTemplate(GetInstructions()).TransformText());
            }
        }
    }
}
