using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeSampledImageNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeSampledImageNodeFactory Instance = new OpTypeSampledImageNodeFactory();

        public OpTypeSampledImageNodeFactory():base(new ScriptNode()
        {
            Name = "TypeSampledImage",
            Category = NodeCategory.Function,
            Type = "OpTypeSampledImage",
            InputPins =
            {
                new PinWithConnection("ImageType",null),
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