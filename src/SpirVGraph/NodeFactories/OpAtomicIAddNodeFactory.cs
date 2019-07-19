using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicIAddNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicIAddNodeFactory Instance = new OpAtomicIAddNodeFactory();

        public OpAtomicIAddNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicIAdd",
            Category = NodeCategory.Function,
            Type = "OpAtomicIAdd",
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