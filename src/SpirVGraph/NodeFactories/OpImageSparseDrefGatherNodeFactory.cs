using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseDrefGatherNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseDrefGatherNodeFactory Instance = new OpImageSparseDrefGatherNodeFactory();

        public OpImageSparseDrefGatherNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseDrefGather",
            Category = NodeCategory.Function,
            Type = "OpImageSparseDrefGather",
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