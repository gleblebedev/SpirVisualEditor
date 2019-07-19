using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseSampleProjExplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseSampleProjExplicitLodNodeFactory Instance = new OpImageSparseSampleProjExplicitLodNodeFactory();

        public OpImageSparseSampleProjExplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseSampleProjExplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSparseSampleProjExplicitLod",
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