using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageReadNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageReadNodeFactory Instance = new OpImageReadNodeFactory();

        public OpImageReadNodeFactory():base(new ScriptNode()
        {
            Name = "ImageRead",
            Category = NodeCategory.Function,
            Type = "OpImageRead",
            InputPins =
            {
                new PinWithConnection("Image",null),
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