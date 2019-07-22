using System;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public abstract class TypeInstruction : InstructionWithId
    {
        public virtual uint SizeInWords { get {throw new NotImplementedException("Can't evaluate value size of type "+this.OpCode);} }

        public virtual bool TryGetFriendlyName(out string name)
        {
            if (OpName != null)
            {
                name = OpName.Name;
                return true;
            }

            if (OpCode == Op.OpTypeFloat)
            {
                if (SizeInWords == 1)
                {
                    name = "float";
                    return true;
                }
                if (SizeInWords == 2)
                {
                    name = "double";
                    return true;
                }
            }
            else if (OpCode == Op.OpTypeInt)
            {
                var op = (OpTypeInt)this;
                if (op.Signedness == 0)
                {
                    if (op.Width == 8)
                    {
                        name = "byte";
                        return true;
                    }
                    if (op.Width == 16)
                    {
                        name = "ushort";
                        return true;
                    }
                    if (op.Width == 32)
                    {
                        name = "uint";
                        return true;
                    }
                    if (op.Width == 64)
                    {
                        name = "ulong";
                        return true;
                    }
                }
                else
                {
                    if (op.Width == 8)
                    {
                        name = "sbyte";
                        return true;
                    }
                    if (op.Width == 16)
                    {
                        name = "short";
                        return true;
                    }
                    if (op.Width == 32)
                    {
                        name = "int";
                        return true;
                    }
                    if (op.Width == 64)
                    {
                        name = "long";
                        return true;
                    }

                }
            }
            else if (OpCode == Op.OpTypeVector)
            {
                var op = (OpTypeVector)this;
                var component = (TypeInstruction)op.ComponentType.Instruction;
                if (component.OpCode == Op.OpTypeFloat && component.SizeInWords == 1)
                {
                    if (op.ComponentCount == 2)
                    {
                        name = "vec2";
                        return true;
                    }
                    if (op.ComponentCount == 3)
                    {
                        name = "vec3";
                        return true;
                    }
                    if (op.ComponentCount == 4)
                    {
                        name = "vec4";
                        return true;
                    }
                }
            }
            else if (OpCode == Op.OpTypeMatrix)
            {
                var op = (OpTypeMatrix)this;
                var column = (TypeInstruction)op.ColumnType.Instruction;
            }

            name = this.OpCode.ToString();
            return false;
        }
    }
}