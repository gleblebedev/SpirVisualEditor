using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpExtensionNodeFactory : AbstractNodeFactory
    {
        public static readonly OpExtensionNodeFactory Instance = new OpExtensionNodeFactory();

        public OpExtensionNodeFactory():base(new ScriptNode()
        {
            Name = "Extension",
            Category = NodeCategory.Function,
            Type = "OpExtension",
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