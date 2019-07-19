using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicIDecrementNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicIDecrementNodeFactory Instance = new OpAtomicIDecrementNodeFactory();

        public OpAtomicIDecrementNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicIDecrement",
            Category = NodeCategory.Function,
            Type = "OpAtomicIDecrement",
            InputPins =
            {
                new PinWithConnection("Pointer",null),
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