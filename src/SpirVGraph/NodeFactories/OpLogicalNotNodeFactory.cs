using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLogicalNotNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLogicalNotNodeFactory Instance = new OpLogicalNotNodeFactory();

        public OpLogicalNotNodeFactory():base(new ScriptNode()
        {
            Name = "LogicalNot",
            Category = NodeCategory.Function,
            Type = "OpLogicalNot",
            InputPins =
            {
                new PinWithConnection("Operand",null),
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