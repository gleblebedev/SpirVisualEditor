using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpEndPrimitiveNodeFactory : AbstractNodeFactory
    {
        public static readonly OpEndPrimitiveNodeFactory Instance = new OpEndPrimitiveNodeFactory();

        public OpEndPrimitiveNodeFactory():base(new ScriptNode()
        {
            Name = "EndPrimitive",
            Category = NodeCategory.Function,
            Type = "OpEndPrimitive",
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