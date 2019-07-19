using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageQueryFormatNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageQueryFormatNodeFactory Instance = new OpImageQueryFormatNodeFactory();

        public OpImageQueryFormatNodeFactory():base(new ScriptNode()
        {
            Name = "ImageQueryFormat",
            Category = NodeCategory.Function,
            Type = "OpImageQueryFormat",
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