using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseSampleExplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseSampleExplicitLodNodeFactory Instance = new OpImageSparseSampleExplicitLodNodeFactory();

        public OpImageSparseSampleExplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseSampleExplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSparseSampleExplicitLod",
            InputPins =
            {
                new PinWithConnection("SampledImage",null),
                new PinWithConnection("Coordinate",null),
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