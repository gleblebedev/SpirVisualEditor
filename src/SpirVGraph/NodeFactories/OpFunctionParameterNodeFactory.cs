using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFunctionParameterNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFunctionParameterNodeFactory Instance = new OpFunctionParameterNodeFactory();

        public OpFunctionParameterNodeFactory():base(new ScriptNode()
        {
            Name = "FunctionParameter",
            Category = NodeCategory.Function,
            Type = "OpFunctionParameter",
            InputPins =
            {
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