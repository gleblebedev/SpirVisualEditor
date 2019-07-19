using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDPdxNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDPdxNodeFactory Instance = new OpDPdxNodeFactory();

        public OpDPdxNodeFactory():base(new ScriptNode()
        {
            Name = "DPdx",
            Category = NodeCategory.Function,
            Type = "OpDPdx",
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