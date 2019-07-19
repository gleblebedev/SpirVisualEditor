using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpNopNodeFactory : AbstractNodeFactory
    {
        public static readonly OpNopNodeFactory Instance = new OpNopNodeFactory();

        public OpNopNodeFactory():base(new ScriptNode()
        {
            Name = "Nop",
            Category = NodeCategory.Function,
            Type = "OpNop",
            InputPins =
            {
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}