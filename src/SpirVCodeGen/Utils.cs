using System;
using SpirVCodeGen.Model;

namespace SpirVCodeGen
{
    internal static class Utils
    {
        public static string GetTypeName(string kind)
        {
            if (IsId(kind))
                return "uint";
            switch (kind)
            {
                case "LiteralContextDependentNumber":
                case "LiteralExtInstInteger":
                case "LiteralInteger":
                case "LiteralSpecConstantOpInteger":
                    return "uint";
                case "LiteralString":
                    return "string";
                default:
                    return "Spv."+kind;

            }
        }
        public static string GetOperandName(Operand operand)
        {
            if (operand.name == null)
                return operand.kind;
            return Utils.GetPropertyName(operand.name);
        }
        public static string GetOperandParser(Operand operand)
        {
            if (operand.quantifier == "?")
                return "Spv." + operand.kind + ".ParseOptional";
            if (operand.quantifier == "*")
                return "Spv." + operand.kind + ".ParseCollection";
            return "Spv." + operand.kind + ".Parse";
        }

        public static string GetOperandType(Operand operand)
        {
            var type = Utils.GetTypeName(operand.kind);
            if (operand.quantifier == "?")
            {
                if (type == "uint")
                    return "uint?";
                return type;
            }
            if (operand.quantifier == "*")
            {
                return "IList<" + type + ">";
            }

            return type;
        }
        public static bool IsBitEnum(string kind)
        {
            switch (kind)
            {
                case "ImageOperands":
                case "FPFastMathMode":
                case "SelectionControl":
                case "LoopControl":
                case "FunctionControl":
                case "MemorySemantics":
                case "MemoryAccess":
                case "KernelProfilingInfo":
                    return true;
            }
            return false;
        }
        public static bool IsValueEnum(string kind)
        {
            switch (kind)
            {
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
                    return true;
            }
            return false;
        }
        public static bool IsId(string kind)
        {
            switch (kind)
            {
                case "IdResultType":
                case "IdResult":
                case "IdMemorySemantics":
                case "IdScope":
                case "IdRef":
                    return true;
            }
            return false;
        }
        public static bool IsLiteral(string kind)
        {
            switch (kind)
            {
                case "LiteralInteger":
                case "LiteralString":
                case "LiteralContextDependentNumber":
                case "LiteralExtInstInteger":
                case "LiteralSpecConstantOpInteger":
                    return true;
            }
            return false;
        }
        public static bool IsComposite(string kind)
        {
            switch (kind)
            {
                case "PairLiteralIntegerIdRef":
                case "PairIdRefLiteralInteger":
                case "PairIdRefIdRef":
                    return true;
            }
            return false;
        }


        public static string GetPropertyName(string name)
        {
            name = name.Trim('\'').Trim('.');
            name = name.Replace(" ", "");
            name = name.Replace("<<Invocation,invocations>>", "Invocations");
            name = name.Replace("-", "");
            name = name.Replace(",", "");
            name = name.Replace("~ref~", "_ref");

            {
                var collectionIndex = name.IndexOf("0\'");
                if (collectionIndex > 0)
                {
                    name = name.Substring(0, collectionIndex) + "s";
                }
            }
            {
                var collectionIndex = name.IndexOf("1\'");
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
}