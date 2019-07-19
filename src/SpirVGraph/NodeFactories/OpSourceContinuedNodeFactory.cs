using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSourceContinuedNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSourceContinuedNodeFactory Instance = new OpSourceContinuedNodeFactory();

        public OpSourceContinuedNodeFactory():base(new ScriptNode()
        {
            Name = "SourceContinued",
            Category = NodeCategory.Function,
            Type = "OpSourceContinued",
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