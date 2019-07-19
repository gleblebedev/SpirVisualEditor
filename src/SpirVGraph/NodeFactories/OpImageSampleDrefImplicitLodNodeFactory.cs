using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSampleDrefImplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSampleDrefImplicitLodNodeFactory Instance = new OpImageSampleDrefImplicitLodNodeFactory();

        public OpImageSampleDrefImplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSampleDrefImplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSampleDrefImplicitLod",
            InputPins =
            {
                new PinWithConnection("SampledImage",null),
                new PinWithConnection("Coordinate",null),
                new PinWithConnection("D_ref",null),
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