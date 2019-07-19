using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageGatherNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageGatherNodeFactory Instance = new OpImageGatherNodeFactory();

        public OpImageGatherNodeFactory():base(new ScriptNode()
        {
            Name = "ImageGather",
            Category = NodeCategory.Function,
            Type = "OpImageGather",
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