using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageDrefGatherNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageDrefGatherNodeFactory Instance = new OpImageDrefGatherNodeFactory();

        public OpImageDrefGatherNodeFactory():base(new ScriptNode()
        {
            Name = "ImageDrefGather",
            Category = NodeCategory.Function,
            Type = "OpImageDrefGather",
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