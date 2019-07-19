using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageQuerySizeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageQuerySizeNodeFactory Instance = new OpImageQuerySizeNodeFactory();

        public OpImageQuerySizeNodeFactory():base(new ScriptNode()
        {
            Name = "ImageQuerySize",
            Category = NodeCategory.Function,
            Type = "OpImageQuerySize",
            InputPins =
            {
                new PinWithConnection("Image",null),
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