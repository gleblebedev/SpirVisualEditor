using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageQuerySizeLodNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageQuerySizeLodNodeFactory Instance = new OpImageQuerySizeLodNodeFactory();

        public OpImageQuerySizeLodNodeFactory():base(new ScriptNode()
        {
            Name = "ImageQuerySizeLod",
            Category = NodeCategory.Function,
            Type = "OpImageQuerySizeLod",
            InputPins =
            {
                new PinWithConnection("Image",null),
                new PinWithConnection("LevelofDetail",null),
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