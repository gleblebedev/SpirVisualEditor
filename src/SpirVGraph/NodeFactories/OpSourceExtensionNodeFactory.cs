using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSourceExtensionNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSourceExtensionNodeFactory Instance = new OpSourceExtensionNodeFactory();

        public OpSourceExtensionNodeFactory():base(new ScriptNode()
        {
            Name = "SourceExtension",
            Category = NodeCategory.Function,
            Type = "OpSourceExtension",
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