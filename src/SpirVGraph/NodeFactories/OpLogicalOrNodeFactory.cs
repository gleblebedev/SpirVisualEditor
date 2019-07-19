using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLogicalOrNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLogicalOrNodeFactory Instance = new OpLogicalOrNodeFactory();

        public OpLogicalOrNodeFactory():base(new ScriptNode()
        {
            Name = "LogicalOr",
            Category = NodeCategory.Function,
            Type = "OpLogicalOr",
            InputPins =
            {
                new PinWithConnection("Operand1",null),
                new PinWithConnection("Operand2",null),
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