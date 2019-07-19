using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupDecorateNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupDecorateNodeFactory Instance = new OpGroupDecorateNodeFactory();

        public OpGroupDecorateNodeFactory():base(new ScriptNode()
        {
            Name = "GroupDecorate",
            Category = NodeCategory.Function,
            Type = "OpGroupDecorate",
            InputPins =
            {
                new PinWithConnection("DecorationGroup",null),
                new PinWithConnection("Targets",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}