using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicCompareExchangeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicCompareExchangeNodeFactory Instance = new OpAtomicCompareExchangeNodeFactory();

        public OpAtomicCompareExchangeNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicCompareExchange",
            Category = NodeCategory.Function,
            Type = "OpAtomicCompareExchange",
            InputPins =
            {
                new PinWithConnection("Pointer",null),
                new PinWithConnection("Value",null),
                new PinWithConnection("Comparator",null),
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