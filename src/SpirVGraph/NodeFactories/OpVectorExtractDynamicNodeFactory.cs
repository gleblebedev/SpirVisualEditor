using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpVectorExtractDynamicNodeFactory : AbstractNodeFactory
    {
        public static readonly OpVectorExtractDynamicNodeFactory Instance = new OpVectorExtractDynamicNodeFactory();

        public OpVectorExtractDynamicNodeFactory():base(new ScriptNode()
        {
            Name = "VectorExtractDynamic",
            Category = NodeCategory.Function,
            Type = "OpVectorExtractDynamic",
            InputPins =
            {
                new PinWithConnection("Vector",null),
                new PinWithConnection("Index",null),
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