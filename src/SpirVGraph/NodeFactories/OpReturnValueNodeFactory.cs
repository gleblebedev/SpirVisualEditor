using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpReturnValueNodeFactory : AbstractNodeFactory
    {
        public static readonly OpReturnValueNodeFactory Instance = new OpReturnValueNodeFactory();

        public OpReturnValueNodeFactory():base(new ScriptNode()
        {
            Name = "ReturnValue",
            Category = NodeCategory.Function,
            Type = "OpReturnValue",
            InputPins =
            {
                new PinWithConnection("Value",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}