using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicCompareExchangeWeakNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicCompareExchangeWeakNodeFactory Instance = new OpAtomicCompareExchangeWeakNodeFactory();

        public OpAtomicCompareExchangeWeakNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicCompareExchangeWeak",
            Category = NodeCategory.Function,
            Type = "OpAtomicCompareExchangeWeak",
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