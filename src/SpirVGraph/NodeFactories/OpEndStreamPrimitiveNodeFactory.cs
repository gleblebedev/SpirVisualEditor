using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpEndStreamPrimitiveNodeFactory : AbstractNodeFactory
    {
        public static readonly OpEndStreamPrimitiveNodeFactory Instance = new OpEndStreamPrimitiveNodeFactory();

        public OpEndStreamPrimitiveNodeFactory():base(new ScriptNode()
        {
            Name = "EndStreamPrimitive",
            Category = NodeCategory.Function,
            Type = "OpEndStreamPrimitive",
            InputPins =
            {
                new PinWithConnection("Stream",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}