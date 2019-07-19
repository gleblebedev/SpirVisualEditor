using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDPdyCoarseNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDPdyCoarseNodeFactory Instance = new OpDPdyCoarseNodeFactory();

        public OpDPdyCoarseNodeFactory():base(new ScriptNode()
        {
            Name = "DPdyCoarse",
            Category = NodeCategory.Function,
            Type = "OpDPdyCoarse",
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