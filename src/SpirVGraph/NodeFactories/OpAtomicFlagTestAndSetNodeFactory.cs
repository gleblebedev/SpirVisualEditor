using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicFlagTestAndSetNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicFlagTestAndSetNodeFactory Instance = new OpAtomicFlagTestAndSetNodeFactory();

        public OpAtomicFlagTestAndSetNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicFlagTestAndSet",
            Category = NodeCategory.Function,
            Type = "OpAtomicFlagTestAndSet",
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