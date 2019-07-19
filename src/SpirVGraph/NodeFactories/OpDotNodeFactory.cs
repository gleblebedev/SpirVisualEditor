using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDotNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDotNodeFactory Instance = new OpDotNodeFactory();

        public OpDotNodeFactory():base(new ScriptNode()
        {
            Name = "Dot",
            Category = NodeCategory.Function,
            Type = "OpDot",
            InputPins =
            {
                new PinWithConnection("Vector1",null),
                new PinWithConnection("Vector2",null),
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