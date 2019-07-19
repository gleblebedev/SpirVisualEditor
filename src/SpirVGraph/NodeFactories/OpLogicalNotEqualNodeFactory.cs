using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLogicalNotEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLogicalNotEqualNodeFactory Instance = new OpLogicalNotEqualNodeFactory();

        public OpLogicalNotEqualNodeFactory():base(new ScriptNode()
        {
            Name = "LogicalNotEqual",
            Category = NodeCategory.Function,
            Type = "OpLogicalNotEqual",
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