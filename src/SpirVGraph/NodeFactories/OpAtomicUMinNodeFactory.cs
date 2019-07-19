using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicUMinNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicUMinNodeFactory Instance = new OpAtomicUMinNodeFactory();

        public OpAtomicUMinNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicUMin",
            Category = NodeCategory.Function,
            Type = "OpAtomicUMin",
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