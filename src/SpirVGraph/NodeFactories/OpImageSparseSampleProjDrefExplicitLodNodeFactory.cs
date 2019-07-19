using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseSampleProjDrefExplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseSampleProjDrefExplicitLodNodeFactory Instance = new OpImageSparseSampleProjDrefExplicitLodNodeFactory();

        public OpImageSparseSampleProjDrefExplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseSampleProjDrefExplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSparseSampleProjDrefExplicitLod",
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