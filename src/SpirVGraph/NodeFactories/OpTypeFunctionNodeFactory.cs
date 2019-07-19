using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeFunctionNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeFunctionNodeFactory Instance = new OpTypeFunctionNodeFactory();

        public OpTypeFunctionNodeFactory():base(new ScriptNode()
        {
            Name = "TypeFunction",
            Category = NodeCategory.Function,
            Type = "OpTypeFunction",
            InputPins =
            {
                new PinWithConnection("ReturnType",null),
                new PinWithConnection("ParameterTypes",null),
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