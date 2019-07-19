using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFwidthCoarseNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFwidthCoarseNodeFactory Instance = new OpFwidthCoarseNodeFactory();

        public OpFwidthCoarseNodeFactory():base(new ScriptNode()
        {
            Name = "FwidthCoarse",
            Category = NodeCategory.Function,
            Type = "OpFwidthCoarse",
            InputPins =
            {
                new PinWithConnection("P",null),
            },
            OutputPins =
            {
                new Pin("out",null),
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}