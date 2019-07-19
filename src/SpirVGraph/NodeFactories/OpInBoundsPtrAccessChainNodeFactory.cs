using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpInBoundsPtrAccessChainNodeFactory : AbstractNodeFactory
    {
        public static readonly OpInBoundsPtrAccessChainNodeFactory Instance = new OpInBoundsPtrAccessChainNodeFactory();

        public OpInBoundsPtrAccessChainNodeFactory():base(new ScriptNode()
        {
            Name = "InBoundsPtrAccessChain",
            Category = NodeCategory.Function,
            Type = "OpInBoundsPtrAccessChain",
            InputPins =
            {
                new PinWithConnection("Base",null),
                new PinWithConnection("Element",null),
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