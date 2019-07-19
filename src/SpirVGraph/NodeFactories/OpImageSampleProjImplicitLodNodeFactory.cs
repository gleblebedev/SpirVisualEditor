using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSampleProjImplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSampleProjImplicitLodNodeFactory Instance = new OpImageSampleProjImplicitLodNodeFactory();

        public OpImageSampleProjImplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSampleProjImplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSampleProjImplicitLod",
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