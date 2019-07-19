using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAccessChainNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAccessChainNodeFactory Instance = new OpAccessChainNodeFactory();

        public OpAccessChainNodeFactory():base(new ScriptNode()
        {
            Name = "AccessChain",
            Category = NodeCategory.Function,
            Type = "OpAccessChain",
            InputPins =
            {
                new PinWithConnection("Base",null),
                new PinWithConnection("Indexes",null),
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