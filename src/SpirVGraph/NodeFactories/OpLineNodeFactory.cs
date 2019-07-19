using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLineNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLineNodeFactory Instance = new OpLineNodeFactory();

        public OpLineNodeFactory():base(new ScriptNode()
        {
            Name = "Line",
            Category = NodeCategory.Function,
            Type = "OpLine",
            InputPins =
            {
                new PinWithConnection("File",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}