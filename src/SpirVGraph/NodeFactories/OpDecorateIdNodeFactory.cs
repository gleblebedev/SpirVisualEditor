using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDecorateIdNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDecorateIdNodeFactory Instance = new OpDecorateIdNodeFactory();

        public OpDecorateIdNodeFactory():base(new ScriptNode()
        {
            Name = "DecorateId",
            Category = NodeCategory.Function,
            Type = "OpDecorateId",
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