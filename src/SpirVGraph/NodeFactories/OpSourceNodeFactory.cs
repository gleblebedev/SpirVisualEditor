using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSourceNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSourceNodeFactory Instance = new OpSourceNodeFactory();

        public OpSourceNodeFactory():base(new ScriptNode()
        {
            Name = "Source",
            Category = NodeCategory.Function,
            Type = "OpSource",
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