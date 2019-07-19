using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCapabilityNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCapabilityNodeFactory Instance = new OpCapabilityNodeFactory();

        public OpCapabilityNodeFactory():base(new ScriptNode()
        {
            Name = "Capability",
            Category = NodeCategory.Function,
            Type = "OpCapability",
            InputPins =
            {
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}