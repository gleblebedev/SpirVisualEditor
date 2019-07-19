using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpUnreachableNodeFactory : AbstractNodeFactory
    {
        public static readonly OpUnreachableNodeFactory Instance = new OpUnreachableNodeFactory();

        public OpUnreachableNodeFactory():base(new ScriptNode()
        {
            Name = "Unreachable",
            Category = NodeCategory.Function,
            Type = "OpUnreachable",
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