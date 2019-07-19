using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicXorNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicXorNodeFactory Instance = new OpAtomicXorNodeFactory();

        public OpAtomicXorNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicXor",
            Category = NodeCategory.Function,
            Type = "OpAtomicXor",
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