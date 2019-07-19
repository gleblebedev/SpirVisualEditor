using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDecorateStringGOOGLENodeFactory : AbstractNodeFactory
    {
        public static readonly OpDecorateStringGOOGLENodeFactory Instance = new OpDecorateStringGOOGLENodeFactory();

        public OpDecorateStringGOOGLENodeFactory():base(new ScriptNode()
        {
            Name = "DecorateStringGOOGLE",
            Category = NodeCategory.Function,
            Type = "OpDecorateStringGOOGLE",
            InputPins =
            {
                new PinWithConnection("Target",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}