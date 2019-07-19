using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFunctionCallNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFunctionCallNodeFactory Instance = new OpFunctionCallNodeFactory();

        public OpFunctionCallNodeFactory():base(new ScriptNode()
        {
            Name = "FunctionCall",
            Category = NodeCategory.Function,
            Type = "OpFunctionCall",
            InputPins =
            {
                new PinWithConnection("Function",null),
                new PinWithConnection("Arguments",null),
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