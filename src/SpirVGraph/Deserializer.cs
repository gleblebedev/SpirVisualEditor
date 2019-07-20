using System;
using System.Collections.Generic;
using System.Linq;
using SpirVGraph.Instructions;
using SpirVGraph.NodeFactories;
using SpirVGraph.Spv;
using Toe.Scripting;

namespace SpirVGraph
{
    public class Deserializer
    {
        private readonly Shader _shader;
        private readonly SpvNodeRegistry _registry;
        private Dictionary<uint, ScriptNode> _nodeById = new Dictionary<uint, ScriptNode>();

        public Deserializer(Shader shader, SpvNodeRegistry registry)
        {
            _shader = shader;
            _registry = registry;
        }
        public Script Deserialize()
        {
            var script = new Script();
            var nodes = new List<Tuple<Instruction, ScriptNode>>();
            bool isInFunction = false;
            ScriptNode prevInstruction = null;
            var nodeMap = new Dictionary<Instruction, ScriptNode>();
            foreach (var instruction in _shader.Instructions)
            {
                if (instruction.OpCode == Op.OpFunction)
                {
                    isInFunction = true;
                    prevInstruction = null;
                }
                if (instruction.OpCode == Op.OpFunctionEnd)
                {
                    isInFunction = false;
                    continue;
                }
                ScriptNode node = null;
                if (instruction.OpCode ==  Op.OpConstant)
                {
                    var op = (OpConstant)instruction;
                    node = new ScriptNode()
                    {
                        Name = op?.OpName?.Name ?? instruction.OpCode.ToString(),
                        Category = NodeCategory.Parameter,
                        Type = instruction.OpCode.ToString(),
                        OutputPins =
                        {
                            new Pin("out",null),
                        },
                        Value = op.Value.ToString()
                    };
                    script.Nodes.Add(node);
                }
                else if (instruction.OpCode == Op.OpVariable)
                {
                    var op = (OpVariable)instruction;
                    node = new ScriptNode()
                    {
                        Name = op?.OpName?.Name ?? instruction.OpCode.ToString(),
                        Category = NodeCategory.Parameter,
                        Type = instruction.OpCode.ToString(),
                        InputPins =
                        {
                            new PinWithConnection("in",null),
                        },
                        OutputPins =
                        {
                            new Pin("out",null),
                        },
                    };
                    script.Nodes.Add(node);
                }
                else if (instruction.OpCode == Op.OpLoad)
                {
                    var op = (OpLoad)instruction;
                    node = nodeMap[op.Pointer.Instruction];
                }
                else if (isInFunction)
                {
                    var op = instruction as InstructionWithId;
                    node = new ScriptNode()
                    {
                        Name = op?.OpName?.Name ?? instruction.OpCode.ToString(),
                        Category = NodeCategory.Function,
                        Type = instruction.OpCode.ToString(),
                        OutputPins =
                        {
                            new Pin("out",null),
                        },
                        EnterPins = { new Pin() },
                        ExitPins = { new PinWithConnection() },
                    };
                    script.Nodes.Add(node);
                    foreach (var arg in instruction.GetReferences())
                    {
                        var pin = new PinWithConnection(arg.Name, null);
                        if (nodeMap.TryGetValue(arg.Reference.Instruction, out var source))
                        {
                            if (source.OutputPins.Count > 0)
                            {
                                pin.Connection = new Connection(source, source.OutputPins[0]);
                            }
                        }
                        node.InputPins.Add(pin);
                    }
                    if (prevInstruction != null)
                    {
                        prevInstruction.ExitPins[0].Connection = new Connection(node, node.EnterPins[0]);
                    }
                    prevInstruction = node;
                }
                if (node != null)
                {
                    nodeMap[instruction] = node;
                }

            }

            return script;
        }

        private void Connect(uint operandId, ScriptNode node, string pin)
        {
            if (!_nodeById.TryGetValue(operandId, out var source))
                return;
            if (source.OutputPins.Count == 0)
                return;
            var input = node.InputPins.FirstOrDefault(_ => _.Id == pin);
            if (input == null)
                return;
            input.Connection = new Connection(source, source.OutputPins[0]);
        }
    }
}