using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicISubNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicISubNodeFactory Instance = new OpAtomicISubNodeFactory();

        public OpAtomicISubNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicISub",
            Category = NodeCategory.Function,
            Type = "OpAtomicISub",
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