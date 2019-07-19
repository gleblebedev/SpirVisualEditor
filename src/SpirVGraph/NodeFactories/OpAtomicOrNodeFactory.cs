using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicOrNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicOrNodeFactory Instance = new OpAtomicOrNodeFactory();

        public OpAtomicOrNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicOr",
            Category = NodeCategory.Function,
            Type = "OpAtomicOr",
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