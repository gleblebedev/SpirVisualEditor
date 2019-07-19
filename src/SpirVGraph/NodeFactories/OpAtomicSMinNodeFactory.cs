using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicSMinNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicSMinNodeFactory Instance = new OpAtomicSMinNodeFactory();

        public OpAtomicSMinNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicSMin",
            Category = NodeCategory.Function,
            Type = "OpAtomicSMin",
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