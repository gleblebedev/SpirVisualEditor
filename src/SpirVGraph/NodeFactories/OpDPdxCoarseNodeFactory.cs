using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDPdxCoarseNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDPdxCoarseNodeFactory Instance = new OpDPdxCoarseNodeFactory();

        public OpDPdxCoarseNodeFactory():base(new ScriptNode()
        {
            Name = "DPdxCoarse",
            Category = NodeCategory.Function,
            Type = "OpDPdxCoarse",
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