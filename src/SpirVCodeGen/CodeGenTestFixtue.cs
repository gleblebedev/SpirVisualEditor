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
            if (operandKind.category == "ValueEnum")
            {
                GenerateEnumFile(operandKind);
                return;
            }
            if (operandKind.category == "BitEnum")
            {
                GenerateBitEnumFile(operandKind);
                return;
            }
            Assert.Ignore(operandKind.category+" not implemented yet.");
        }

        public void GenerateEnumFile(OperandKind enumeration)
        {
            var text = new EnumTemplate(enumeration).TransformText();
            var path = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location),
                @"..\..\..\..\SpirVGraph\Spv\" + enumeration.kind + ".cs");
            using (var file = File.CreateText(path))
            {
                file.Write(text);
            }
        }
        public void GenerateBitEnumFile(OperandKind enumeration)
        {
            var text = new FlagTemplate(enumeration).TransformText();
            var path = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location),
                @"..\..\..\..\SpirVGraph\Spv\" + enumeration.kind + ".cs");
            using (var file = File.CreateText(path))
            {
                file.Write(text);
            }
        }

        [Test]
        public void GetAllFlags()
        {
            foreach (var operandKind in GetOperandKinds())
            {
                if (operandKind.category == "ValueEnum" || operandKind.category == "BitEnum")
                {
                    Console.WriteLine(@"
        public static " + operandKind.kind + @" Parse" + operandKind.kind + @"(WordReader reader, uint wordCount)
        {
            return " + operandKind.kind + @".Parse(reader, wordCount);
        }");
                }
                else
                {
                    Console.WriteLine(@"
        public static uint Parse" + operandKind.kind + @"(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }");
                }
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
