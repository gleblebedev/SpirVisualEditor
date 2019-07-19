using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLogicalAndNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLogicalAndNodeFactory Instance = new OpLogicalAndNodeFactory();

        public OpLogicalAndNodeFactory():base(new ScriptNode()
        {
            Name = "LogicalAnd",
            Category = NodeCategory.Function,
            Type = "OpLogicalAnd",
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