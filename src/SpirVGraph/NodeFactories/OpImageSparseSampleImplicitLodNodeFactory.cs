using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseSampleImplicitLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseSampleImplicitLodNodeFactory Instance = new OpImageSparseSampleImplicitLodNodeFactory();

        public OpImageSparseSampleImplicitLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseSampleImplicitLod",
            Category = NodeCategory.Function,
            Type = "OpImageSparseSampleImplicitLod",
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