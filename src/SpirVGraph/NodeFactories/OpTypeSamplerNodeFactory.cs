using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeSamplerNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeSamplerNodeFactory Instance = new OpTypeSamplerNodeFactory();

        public OpTypeSamplerNodeFactory():base(new ScriptNode()
        {
            Name = "TypeSampler",
            Category = NodeCategory.Function,
            Type = "OpTypeSampler",
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