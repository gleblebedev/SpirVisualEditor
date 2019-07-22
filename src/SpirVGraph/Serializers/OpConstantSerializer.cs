using System.Collections.Generic;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Toe.Scripting;


namespace SpirVGraph.Serializers
{
    public partial class OpConstantSerializer: FunctionSerializer<OpConstant>
    {
        public override void Deserialize(OpConstant instruction, ScriptNode node, Deserializer context)
        {
            CreateOutputPin(node, instruction.IdResultType.Instruction);
            node.Value = instruction.Value.ToString();
        }
    }
}