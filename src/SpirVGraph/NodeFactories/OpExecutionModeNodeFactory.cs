using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpExecutionModeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpExecutionModeNodeFactory Instance = new OpExecutionModeNodeFactory();

        public OpExecutionModeNodeFactory():base(new ScriptNode()
        {
            Name = "ExecutionMode",
            Category = NodeCategory.Function,
            Type = "OpExecutionMode",
            InputPins =
            {
                new PinWithConnection("EntryPoint",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}