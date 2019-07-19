using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseSampleDrefExplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseSampleDrefExplicitLodNodeFactory Instance = new OpImageSparseSampleDrefExplicitLodNodeFactory();

        public OpImageSparseSampleDrefExplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseSampleDrefExplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSparseSampleDrefExplicitLod",
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