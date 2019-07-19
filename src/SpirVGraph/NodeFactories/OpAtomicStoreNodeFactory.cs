using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicStoreNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicStoreNodeFactory Instance = new OpAtomicStoreNodeFactory();

        public OpAtomicStoreNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicStore",
            Category = NodeCategory.Function,
            Type = "OpAtomicStore",
            InputPins =
            {
                new PinWithConnection("Pointer",null),
                new PinWithConnection("Value",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}