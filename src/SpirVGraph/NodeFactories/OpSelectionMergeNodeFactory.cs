using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSelectionMergeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSelectionMergeNodeFactory Instance = new OpSelectionMergeNodeFactory();

        public OpSelectionMergeNodeFactory():base(new ScriptNode()
        {
            Name = "SelectionMerge",
            Category = NodeCategory.Function,
            Type = "OpSelectionMerge",
            InputPins =
            {
                new PinWithConnection("MergeBlock",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}