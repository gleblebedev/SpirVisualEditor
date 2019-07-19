using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpVectorInsertDynamicNodeFactory : AbstractNodeFactory
    {
        public static readonly OpVectorInsertDynamicNodeFactory Instance = new OpVectorInsertDynamicNodeFactory();

        public OpVectorInsertDynamicNodeFactory():base(new ScriptNode()
        {
            Name = "VectorInsertDynamic",
            Category = NodeCategory.Function,
            Type = "OpVectorInsertDynamic",
            InputPins =
            {
                new PinWithConnection("Vector",null),
                new PinWithConnection("Component",null),
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