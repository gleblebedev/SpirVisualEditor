using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpirVCodeGen.Model;

namespace SpirVCodeGen
{
    public partial class IdTemplate : IdTemplateBase
    {
        private readonly OperandKind _operandKind;

        public IdTemplate(OperandKind operandKind)
        {
            _operandKind = operandKind;
        }

        public string Name
        {
            get { return _operandKind.kind; }
        }
    }
    public partial class CompositeTemplate : CompositeTemplateBase
    {
        private readonly OperandKind _operandKind;

        public CompositeTemplate(OperandKind operandKind)
        {
            _operandKind = operandKind;
            var bases = new List<Property>();
            var visitedPropertyNames = new HashSet<string>();
            foreach (var type in operandKind.bases ?? EmptyReadOnlyList<string>.Instance)
            {
                string name = type;
                if (!visitedPropertyNames.Add(name))
                {
                    for (int i=2; ; i++)
                    {
                        name = type + i;
                        if (visitedPropertyNames.Add(name))
                            break;
                    }
                }
                var property = new Property()
                {
                    Type = Utils.GetTypeName(type),
                    Base = type,
                    Name = name
                };
                bases.Add(property);
            }

            this.bases = bases;
        }

        public string Name
        {
            get { return _operandKind.kind; }
        }

        public IReadOnlyList<Property> bases { get; set; }

        public class Property
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Base { get; set; }
        }
    }
    public partial class LiteralTemplate : LiteralTemplateBase
    {
        private readonly OperandKind _operandKind;

        public LiteralTemplate(OperandKind operandKind)
        {
            _operandKind = operandKind;
        }

        public string Name
        {
            get { return _operandKind.kind; }
        }
    }
    public partial class EnumTemplate : EnumTemplateBase
    {
        private readonly OperandKind _operandKind;

        public EnumTemplate(OperandKind operandKind)
        {
            _operandKind = operandKind;
        }

        public string Name { get { return _operandKind.kind; }}
        public IReadOnlyList<Enumerant> Values { get { return _operandKind.enumerants ?? EmptyReadOnlyList<Enumerant>.Instance; } }

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

        public IReadOnlyList<Operand> operands
        {
            get => _instruction.operands ?? EmptyReadOnlyList<Operand>.Instance;
        }

        public InstructionTemplate(Instruction instruction)
        {
            _instruction = instruction;
        }
    }
    public partial class NodeFactoryTemplate : NodeFactoryTemplateBase
    {
        private readonly Instruction _instruction;
        public string opname
        {
            get => _instruction.opname;
            set => _instruction.opname = value;
        }

        public IReadOnlyList<Operand> operands
        {
            get => _instruction.operands ?? EmptyReadOnlyList<Operand>.Instance;
        }

        public NodeFactoryTemplate(Instruction instruction)
        {
            _instruction = instruction;
        }
    }
}
