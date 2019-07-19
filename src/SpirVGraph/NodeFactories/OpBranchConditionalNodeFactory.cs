using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBranchConditionalNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBranchConditionalNodeFactory Instance = new OpBranchConditionalNodeFactory();

        public OpBranchConditionalNodeFactory():base(new ScriptNode()
        {
            Name = "BranchConditional",
            Category = NodeCategory.Function,
            Type = "OpBranchConditional",
            InputPins =
            {
                new PinWithConnection("Condition",null),
                new PinWithConnection("TrueLabel",null),
                new PinWithConnection("FalseLabel",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}