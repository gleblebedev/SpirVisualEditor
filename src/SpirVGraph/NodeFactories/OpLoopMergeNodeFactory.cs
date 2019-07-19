using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLoopMergeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLoopMergeNodeFactory Instance = new OpLoopMergeNodeFactory();

        public OpLoopMergeNodeFactory():base(new ScriptNode()
        {
            Name = "LoopMerge",
            Category = NodeCategory.Function,
            Type = "OpLoopMerge",
            InputPins =
            {
                new PinWithConnection("MergeBlock",null),
                new PinWithConnection("ContinueTarget",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}