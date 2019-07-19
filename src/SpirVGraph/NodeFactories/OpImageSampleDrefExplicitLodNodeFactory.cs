using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSampleDrefExplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSampleDrefExplicitLodNodeFactory Instance = new OpImageSampleDrefExplicitLodNodeFactory();

        public OpImageSampleDrefExplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSampleDrefExplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSampleDrefExplicitLod",
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