using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpirVCodeGen.Model;

namespace SpirVCodeGen
{
    internal static class Utils
    {
        public static string GetPropertyName(string name)
        {
            name = name.Trim('\'').Trim('.');
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            name = name.Replace("~ref~", "_ref");
            name = name.Replace("<<Invocation,invocations>>", "Invocations");

            {
                var collectionIndex = name.IndexOf("0\'");
                if (collectionIndex > 0)
                {
                    name = name.Substring(0, collectionIndex) + "s";
                }
            }
            {
                var collectionIndex = name.IndexOf("0Type\'", StringComparison.InvariantCultureIgnoreCase);
                if (collectionIndex > 0)
                {
                    name = name.Substring(0, collectionIndex) + "Types";
                }
            }
            return name;
        }
    }
    public partial class EnumTemplate : EnumTemplateBase
    {
        private readonly OperandKind _enumeration;

        public EnumTemplate(OperandKind enumeration)
        {
            _enumeration = enumeration;
        }

        public string Name { get { return _enumeration.kind; }}
        public IReadOnlyList<Enumerant> Values { get { return _enumeration.enumerants ?? EmptyReadOnlyList<Enumerant>.Instance; } }

        public string GetName(string enumerant, Parameter parameter)
        {
            var res = GetParameterName(parameter);
            if (res == enumerant)
                return res+"Value";
            return res;
        }

        private static string GetParameterName(Parameter parameter)
        {
            if (string.IsNullOrWhiteSpace(parameter.name))
                return parameter.kind;
            return Utils.GetPropertyName(parameter.name);
        }

        public string GetParameterType(string kind)
        {
            switch (kind)
            {
                case "LiteralString":
                    return "string";
                case "LiteralInteger":
                case "IdRef":
                    return "uint";
                default:
                    return "Spv."+kind;
            }
        }

        public string GetId(string id)
        {
            if (char.IsDigit(id[0]))
                return Name + id;
            return id;
        }
    }
    public partial class FlagTemplate : FlagTemplateBase
    {
        private readonly OperandKind _enumeration;

        public FlagTemplate(OperandKind enumeration)
        {
            _enumeration = enumeration;
        }

        public string Name { get { return _enumeration.kind; } }
        public IReadOnlyList<Enumerant> Values { get { return _enumeration.enumerants ?? EmptyReadOnlyList<Enumerant>.Instance; } }

        public string GetId(string id)
        {
            if (char.IsDigit(id[0]))
                return Name + id;
            return id;
        }
    }
    public partial class InstructionFactoryTemplate : InstructionFactoryTemplateBase
    {
        private readonly IEnumerable<Instruction> _instructions;

        public InstructionFactoryTemplate(IEnumerable<Instruction> instructions)
        {
            _instructions = instructions;
        }

        public IEnumerable<Instruction> Instructions
        {
            get { return _instructions; }
        }
    }

    public partial class InstructionTemplate : InstructionTemplateBase
    {
        private readonly Instruction _instruction;
        public string opname
        {
            get => _instruction.opname;
            set => _instruction.opname = value;
        }

        public int opcode
        {
            get => _instruction.opcode;
            set => _instruction.opcode = value;
        }

        public IReadOnlyList<Operand> operands
        {
            get => _instruction.operands ?? EmptyReadOnlyList<Operand>.Instance;
        }

        public List<string> capabilities
        {
            get => _instruction.capabilities;
            set => _instruction.capabilities = value;
        }

        public List<string> extensions
        {
            get => _instruction.extensions;
            set => _instruction.extensions = value;
        }

        public InstructionTemplate(Instruction instruction)
        {
            _instruction = instruction;
        }

        public string GetOperandType(Operand operand)
        {
            switch (operand.kind)
            {
                case "IdResultType":
                case "IdResult":
                case "IdRef":
                case "IdScope":
                case "LiteralInteger":
                case "LiteralExtInstInteger":
                case "IdMemorySemantics":
                    if (operand.quantifier == "?")
                        return "uint?";
                    else if (operand.quantifier == "*")
                        return "IList<uint>";
                    else if (string.IsNullOrWhiteSpace(operand.quantifier))
                        return "uint";
                    else
                        throw new NotImplementedException();
                case "PairIdRefLiteralInteger":
                case "PairLiteralIntegerIdRef":
                    if (operand.quantifier == "*")
                        return "IList<IdAndLiteral>";
                    else
                        throw new NotImplementedException();

                case "ImageOperands":
                case "FPFastMathMode":
                case "SelectionControl":
                case "LoopControl":
                case "FunctionControl":
                case "MemorySemantics":
                case "MemoryAccess":
                case "KernelProfilingInfo":
                case "SourceLanguage":
                case "ExecutionModel":
                case "AddressingModel":
                case "MemoryModel":
                case "ExecutionMode":
                case "StorageClass":
                case "Dim":
                case "SamplerAddressingMode":
                case "SamplerFilterMode":
                case "ImageFormat":
                case "ImageChannelOrder":
                case "ImageChannelDataType":
                case "FPRoundingMode":
                case "LinkageType":
                case "AccessQualifier":
                case "FunctionParameterAttribute":
                case "Decoration":
                case "BuiltIn":
                case "Scope":
                case "GroupOperation":
                case "KernelEnqueueFlags":
                case "Capability":
                    if (operand.quantifier == "?")
                        return operand.kind;
                    if (string.IsNullOrWhiteSpace(operand.quantifier))
                        return operand.kind;
                    else
                        throw new NotImplementedException();
                case "LiteralString":
                    if (operand.quantifier == "?")
                        return "string";
                    if (string.IsNullOrWhiteSpace(operand.quantifier))
                        return "string";
                    else
                        throw new NotImplementedException();
                default:
                    throw new NotImplementedException("Unknown operand kind "+operand.kind);
            }
        }
        public string GetOperandName(Operand operand)
        {
            if (operand.name == null)
                return operand.kind;
            return Utils.GetPropertyName(operand.name);
        }
        public string GetOperandParser(Operand operand)
        {
            switch (operand.kind)
            {
                case "IdResultType":
                case "IdResult":
                case "IdRef":
                case "IdScope":
                case "LiteralInteger":
                case "IdMemorySemantics":
                    if (operand.quantifier == "?")
                        return "ParseOptionalWord";
                    else if (operand.quantifier == "*")
                        return "ParseWordCollection";
                    else
                        return "ParseWord";
                case "PairIdRefLiteralInteger":
                    if (operand.quantifier == "*")
                        return "ParsePairIdRefLiteralIntegerCollection";
                    else
                        throw new NotImplementedException();
                case "PairLiteralIntegerIdRef":
                    if (operand.quantifier == "*")
                        return "ParsePairLiteralIntegerIdRefCollection";
                    else
                        throw new NotImplementedException();

                case "ImageOperands":
                case "FPFastMathMode":
                case "SelectionControl":
                case "LoopControl":
                case "FunctionControl":
                case "MemorySemantics":
                case "MemoryAccess":
                case "KernelProfilingInfo":
                case "SourceLanguage":
                case "ExecutionModel":
                case "AddressingModel":
                case "MemoryModel":
                case "ExecutionMode":
                case "StorageClass":
                case "Dim":
                case "SamplerAddressingMode":
                case "SamplerFilterMode":
                case "ImageFormat":
                case "ImageChannelOrder":
                case "ImageChannelDataType":
                case "FPRoundingMode":
                case "LinkageType":
                case "AccessQualifier":
                case "FunctionParameterAttribute":
                case "Decoration":
                case "BuiltIn":
                case "Scope":
                case "GroupOperation":
                case "KernelEnqueueFlags":
                case "Capability":
                    if (operand.quantifier == "?")
                        return operand.kind + ".ParseOptional";
                    else if (string.IsNullOrWhiteSpace(operand.quantifier))
                        return operand.kind + ".Parse";
                    else
                        throw new NotImplementedException();
                case "LiteralString":
                    if (operand.quantifier == "?")
                        return "ParseString";
                    if (string.IsNullOrWhiteSpace(operand.quantifier))
                        return "ParseString";
                    else
                        throw new NotImplementedException();
                default:
                    throw new NotImplementedException("Unknown operand kind " + operand.kind);
            }
        }
    }
}
