using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseSampleDrefImplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseSampleDrefImplicitLodNodeFactory Instance = new OpImageSparseSampleDrefImplicitLodNodeFactory();

        public OpImageSparseSampleDrefImplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseSampleDrefImplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSparseSampleDrefImplicitLod",
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