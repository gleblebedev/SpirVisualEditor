using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageQueryOrderNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageQueryOrderNodeFactory Instance = new OpImageQueryOrderNodeFactory();

        public OpImageQueryOrderNodeFactory():base(new ScriptNode()
        {
            Name = "ImageQueryOrder",
            Category = NodeCategory.Function,
            Type = "OpImageQueryOrder",
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