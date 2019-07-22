using System.Collections.Generic;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Toe.Scripting;


namespace SpirVGraph.Serializers
{
    public partial class OpBranchSerializer: ProcedureSerializer<OpBranch>
    {
        public override void Deserialize(OpBranch instruction, ScriptNode node, Deserializer context)
        {
            node.EnterPins.Add(new Pin());
            var exit = new PinWithConnection("",null);
            node.ExitPins.Add(exit);
            var target = context.Deserialize(instruction.TargetLabel.Instruction);
            if (exit.Connection == null)
            {
                exit.Connection = new Connection(target, target.EnterPins[0]);
            }
        }
    }
}