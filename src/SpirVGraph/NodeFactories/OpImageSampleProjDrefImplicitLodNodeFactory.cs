using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSampleProjDrefImplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSampleProjDrefImplicitLodNodeFactory Instance = new OpImageSampleProjDrefImplicitLodNodeFactory();

        public OpImageSampleProjDrefImplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSampleProjDrefImplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSampleProjDrefImplicitLod",
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