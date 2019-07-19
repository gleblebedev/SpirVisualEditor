using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageWriteNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageWriteNodeFactory Instance = new OpImageWriteNodeFactory();

        public OpImageWriteNodeFactory():base(new ScriptNode()
        {
            Name = "ImageWrite",
            Category = NodeCategory.Function,
            Type = "OpImageWrite",
            InputPins =
            {
                new PinWithConnection("Image",null),
                new PinWithConnection("Coordinate",null),
                new PinWithConnection("Texel",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}