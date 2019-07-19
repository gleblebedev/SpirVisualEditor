using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicAndNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicAndNodeFactory Instance = new OpAtomicAndNodeFactory();

        public OpAtomicAndNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicAnd",
            Category = NodeCategory.Function,
            Type = "OpAtomicAnd",
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