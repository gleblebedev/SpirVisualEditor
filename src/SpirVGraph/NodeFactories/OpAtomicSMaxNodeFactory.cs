using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicSMaxNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicSMaxNodeFactory Instance = new OpAtomicSMaxNodeFactory();

        public OpAtomicSMaxNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicSMax",
            Category = NodeCategory.Function,
            Type = "OpAtomicSMax",
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