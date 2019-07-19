using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicIIncrementNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicIIncrementNodeFactory Instance = new OpAtomicIIncrementNodeFactory();

        public OpAtomicIIncrementNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicIIncrement",
            Category = NodeCategory.Function,
            Type = "OpAtomicIIncrement",
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