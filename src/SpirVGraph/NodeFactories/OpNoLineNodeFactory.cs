using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpNoLineNodeFactory : AbstractNodeFactory
    {
        public static readonly OpNoLineNodeFactory Instance = new OpNoLineNodeFactory();

        public OpNoLineNodeFactory():base(new ScriptNode()
        {
            Name = "NoLine",
            Category = NodeCategory.Function,
            Type = "OpNoLine",
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