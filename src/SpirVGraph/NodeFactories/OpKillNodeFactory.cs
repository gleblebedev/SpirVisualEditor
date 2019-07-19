using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpKillNodeFactory : AbstractNodeFactory
    {
        public static readonly OpKillNodeFactory Instance = new OpKillNodeFactory();

        public OpKillNodeFactory():base(new ScriptNode()
        {
            Name = "Kill",
            Category = NodeCategory.Function,
            Type = "OpKill",
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