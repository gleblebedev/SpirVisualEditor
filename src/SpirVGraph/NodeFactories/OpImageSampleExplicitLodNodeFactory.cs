using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSampleExplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSampleExplicitLodNodeFactory Instance = new OpImageSampleExplicitLodNodeFactory();

        public OpImageSampleExplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSampleExplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSampleExplicitLod",
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