using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageFetchNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageFetchNodeFactory Instance = new OpImageFetchNodeFactory();

        public OpImageFetchNodeFactory():base(new ScriptNode()
        {
            Name = "ImageFetch",
            Category = NodeCategory.Function,
            Type = "OpImageFetch",
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