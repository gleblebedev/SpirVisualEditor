using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseSampleProjImplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseSampleProjImplicitLodNodeFactory Instance = new OpImageSparseSampleProjImplicitLodNodeFactory();

        public OpImageSparseSampleProjImplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseSampleProjImplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSparseSampleProjImplicitLod",
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