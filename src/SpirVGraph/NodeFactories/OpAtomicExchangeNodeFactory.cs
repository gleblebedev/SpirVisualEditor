using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicExchangeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicExchangeNodeFactory Instance = new OpAtomicExchangeNodeFactory();

        public OpAtomicExchangeNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicExchange",
            Category = NodeCategory.Function,
            Type = "OpAtomicExchange",
            InputPins =
            {
                new PinWithConnection("Pointer",null),
                new PinWithConnection("Value",null),
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