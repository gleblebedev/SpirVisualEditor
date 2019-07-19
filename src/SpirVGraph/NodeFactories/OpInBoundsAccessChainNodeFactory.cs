using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpInBoundsAccessChainNodeFactory : AbstractNodeFactory
    {
        public static readonly OpInBoundsAccessChainNodeFactory Instance = new OpInBoundsAccessChainNodeFactory();

        public OpInBoundsAccessChainNodeFactory():base(new ScriptNode()
        {
            Name = "InBoundsAccessChain",
            Category = NodeCategory.Function,
            Type = "OpInBoundsAccessChain",
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