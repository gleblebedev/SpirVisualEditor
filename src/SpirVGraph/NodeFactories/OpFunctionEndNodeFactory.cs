using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFunctionEndNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFunctionEndNodeFactory Instance = new OpFunctionEndNodeFactory();

        public OpFunctionEndNodeFactory():base(new ScriptNode()
        {
            Name = "FunctionEnd",
            Category = NodeCategory.Function,
            Type = "OpFunctionEnd",
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