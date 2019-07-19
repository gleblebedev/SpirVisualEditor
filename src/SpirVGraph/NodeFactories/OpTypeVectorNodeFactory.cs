using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeVectorNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeVectorNodeFactory Instance = new OpTypeVectorNodeFactory();

        public OpTypeVectorNodeFactory():base(new ScriptNode()
        {
            Name = "TypeVector",
            Category = NodeCategory.Function,
            Type = "OpTypeVector",
            InputPins =
            {
                new PinWithConnection("ComponentType",null),
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