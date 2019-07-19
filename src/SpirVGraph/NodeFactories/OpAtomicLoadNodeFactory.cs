using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicLoadNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicLoadNodeFactory Instance = new OpAtomicLoadNodeFactory();

        public OpAtomicLoadNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicLoad",
            Category = NodeCategory.Function,
            Type = "OpAtomicLoad",
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