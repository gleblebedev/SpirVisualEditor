using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFunctionNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFunctionNodeFactory Instance = new OpFunctionNodeFactory();

        public OpFunctionNodeFactory():base(new ScriptNode()
        {
            Name = "Function",
            Category = NodeCategory.Function,
            Type = "OpFunction",
            InputPins =
            {
                new PinWithConnection("FunctionType",null),
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