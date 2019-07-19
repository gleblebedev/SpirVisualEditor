using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseGatherNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseGatherNodeFactory Instance = new OpImageSparseGatherNodeFactory();

        public OpImageSparseGatherNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseGather",
            Category = NodeCategory.Function,
            Type = "OpImageSparseGather",
            InputPins =
            {
                new PinWithConnection("SampledImage",null),
                new PinWithConnection("Coordinate",null),
                new PinWithConnection("Component",null),
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