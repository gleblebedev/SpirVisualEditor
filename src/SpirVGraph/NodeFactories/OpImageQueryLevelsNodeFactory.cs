using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageQueryLevelsNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageQueryLevelsNodeFactory Instance = new OpImageQueryLevelsNodeFactory();

        public OpImageQueryLevelsNodeFactory():base(new ScriptNode()
        {
            Name = "ImageQueryLevels",
            Category = NodeCategory.Function,
            Type = "OpImageQueryLevels",
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