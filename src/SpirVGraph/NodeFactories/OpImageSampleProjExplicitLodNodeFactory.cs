using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSampleProjExplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSampleProjExplicitLodNodeFactory Instance = new OpImageSampleProjExplicitLodNodeFactory();

        public OpImageSampleProjExplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSampleProjExplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSampleProjExplicitLod",
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