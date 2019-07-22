using System.Collections.Generic;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Toe.Scripting;


namespace SpirVGraph.Serializers
{
    public partial class OpBranchConditionalSerializer: ProcedureSerializer<OpBranchConditional>
    {
        public override void Deserialize(OpBranchConditional instruction, ScriptNode node, Deserializer context)
        {
            node.EnterPins.Add(new Pin());
            var trueLabel = new PinWithConnection(nameof(instruction.TrueLabel), null);
            var falseLabel = new PinWithConnection(nameof(instruction.FalseLabel), null);
            node.ExitPins.Add(trueLabel);
            node.ExitPins.Add(falseLabel);
            var target = context.Deserialize(instruction.TrueLabel.Instruction);
            if (trueLabel.Connection == null)
            {
                trueLabel.Connection = new Connection(target, target.EnterPins[0]);
            }
            target = context.Deserialize(instruction.FalseLabel.Instruction);
            if (falseLabel.Connection == null)
            {
                falseLabel.Connection = new Connection(target, target.EnterPins[0]);
            }
        }
    }
}