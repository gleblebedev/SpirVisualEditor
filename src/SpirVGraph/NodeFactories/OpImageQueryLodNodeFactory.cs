using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageQueryLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageQueryLodNodeFactory Instance = new OpImageQueryLodNodeFactory();

        public OpImageQueryLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageQueryLod",
            Category = NodeCategory.Function,
            Type = "OpImageQueryLod",
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