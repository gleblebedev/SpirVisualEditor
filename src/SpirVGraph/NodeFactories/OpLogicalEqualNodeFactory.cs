using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLogicalEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLogicalEqualNodeFactory Instance = new OpLogicalEqualNodeFactory();

        public OpLogicalEqualNodeFactory():base(new ScriptNode()
        {
            Name = "LogicalEqual",
            Category = NodeCategory.Function,
            Type = "OpLogicalEqual",
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