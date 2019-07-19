using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpEntryPointNodeFactory : AbstractNodeFactory
    {
        public static readonly OpEntryPointNodeFactory Instance = new OpEntryPointNodeFactory();

        public OpEntryPointNodeFactory():base(new ScriptNode()
        {
            Name = "EntryPoint",
            Category = NodeCategory.Function,
            Type = "OpEntryPoint",
            InputPins =
            {
                new PinWithConnection("EntryPoint",null),
                new PinWithConnection("Interface",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}