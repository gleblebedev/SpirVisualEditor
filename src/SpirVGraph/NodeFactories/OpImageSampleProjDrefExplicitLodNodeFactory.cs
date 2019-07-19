using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSampleProjDrefExplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSampleProjDrefExplicitLodNodeFactory Instance = new OpImageSampleProjDrefExplicitLodNodeFactory();

        public OpImageSampleProjDrefExplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSampleProjDrefExplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSampleProjDrefExplicitLod",
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