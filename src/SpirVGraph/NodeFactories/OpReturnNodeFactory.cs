using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpReturnNodeFactory : AbstractNodeFactory
    {
        public static readonly OpReturnNodeFactory Instance = new OpReturnNodeFactory();

        public OpReturnNodeFactory():base(new ScriptNode()
        {
            Name = "Return",
            Category = NodeCategory.Function,
            Type = "OpReturn",
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