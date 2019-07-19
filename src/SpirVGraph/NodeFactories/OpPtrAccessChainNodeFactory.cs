using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpPtrAccessChainNodeFactory : AbstractNodeFactory
    {
        public static readonly OpPtrAccessChainNodeFactory Instance = new OpPtrAccessChainNodeFactory();

        public OpPtrAccessChainNodeFactory():base(new ScriptNode()
        {
            Name = "PtrAccessChain",
            Category = NodeCategory.Function,
            Type = "OpPtrAccessChain",
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