using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseSampleProjDrefImplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseSampleProjDrefImplicitLodNodeFactory Instance = new OpImageSparseSampleProjDrefImplicitLodNodeFactory();

        public OpImageSparseSampleProjDrefImplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseSampleProjDrefImplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSparseSampleProjDrefImplicitLod",
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