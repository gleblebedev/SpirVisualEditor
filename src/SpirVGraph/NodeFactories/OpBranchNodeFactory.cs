using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBranchNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBranchNodeFactory Instance = new OpBranchNodeFactory();

        public OpBranchNodeFactory():base(new ScriptNode()
        {
            Name = "Branch",
            Category = NodeCategory.Function,
            Type = "OpBranch",
            InputPins =
            {
                new PinWithConnection("TargetLabel",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}