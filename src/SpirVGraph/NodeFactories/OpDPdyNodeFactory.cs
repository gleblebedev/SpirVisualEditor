using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDPdyNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDPdyNodeFactory Instance = new OpDPdyNodeFactory();

        public OpDPdyNodeFactory():base(new ScriptNode()
        {
            Name = "DPdy",
            Category = NodeCategory.Function,
            Type = "OpDPdy",
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