using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAtomicFlagClearNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAtomicFlagClearNodeFactory Instance = new OpAtomicFlagClearNodeFactory();

        public OpAtomicFlagClearNodeFactory():base(new ScriptNode()
        {
            Name = "AtomicFlagClear",
            Category = NodeCategory.Function,
            Type = "OpAtomicFlagClear",
            InputPins =
            {
                new PinWithConnection("Pointer",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}