using System.Collections.Generic;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Toe.Scripting;


namespace SpirVGraph.Serializers
{
    public partial class OpLoopMergeSerializer: ProcedureSerializer<OpLoopMerge>
    {
        public override void Deserialize(OpLoopMerge instruction, ScriptNode node, Deserializer context)
        {
            node.EnterPins.Add(new Pin());
            var mergeBlock = new PinWithConnection(nameof(instruction.MergeBlock), null);
            var continueTarget = new PinWithConnection(nameof(instruction.ContinueTarget), null);
            node.ExitPins.Add(mergeBlock);
            node.ExitPins.Add(continueTarget);
            var target = context.Deserialize(instruction.MergeBlock.Instruction);
            if (mergeBlock.Connection == null)
            {
                mergeBlock.Connection = new Connection(target, target.EnterPins[0]);
            }
            target = context.Deserialize(instruction.ContinueTarget.Instruction);
            if (continueTarget.Connection == null)
            {
                continueTarget.Connection = new Connection(target, target.EnterPins[0]);
            }
        }
    }
}