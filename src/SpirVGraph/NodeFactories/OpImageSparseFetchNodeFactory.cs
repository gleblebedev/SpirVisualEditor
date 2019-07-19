using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseFetchNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseFetchNodeFactory Instance = new OpImageSparseFetchNodeFactory();

        public OpImageSparseFetchNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseFetch",
            Category = NodeCategory.Function,
            Type = "OpImageSparseFetch",
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