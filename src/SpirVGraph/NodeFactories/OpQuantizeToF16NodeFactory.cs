using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpQuantizeToF16NodeFactory : AbstractNodeFactory
    {
        public static readonly OpQuantizeToF16NodeFactory Instance = new OpQuantizeToF16NodeFactory();

        public OpQuantizeToF16NodeFactory():base(new ScriptNode()
        {
            Name = "QuantizeToF16",
            Category = NodeCategory.Function,
            Type = "OpQuantizeToF16",
            InputPins =
            {
                new PinWithConnection("Value",null),
            },
            OutputPins =
            {
                new Pin("out",null),
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}