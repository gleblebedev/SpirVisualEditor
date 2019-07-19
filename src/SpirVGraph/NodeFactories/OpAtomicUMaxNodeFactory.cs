using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicUMaxNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicUMaxNodeFactory Instance = new OpAtomicUMaxNodeFactory();

        public OpAtomicUMaxNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicUMax",
            Category = NodeCategory.Function,
            Type = "OpAtomicUMax",
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