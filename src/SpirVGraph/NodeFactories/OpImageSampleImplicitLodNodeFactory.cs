using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSampleImplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSampleImplicitLodNodeFactory Instance = new OpImageSampleImplicitLodNodeFactory();

        public OpImageSampleImplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSampleImplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSampleImplicitLod",
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