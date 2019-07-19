using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDecorateNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDecorateNodeFactory Instance = new OpDecorateNodeFactory();

        public OpDecorateNodeFactory():base(new ScriptNode()
        {
            Name = "Decorate",
            Category = NodeCategory.Function,
            Type = "OpDecorate",
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