using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpISubBorrowNodeFactory : AbstractNodeFactory
    {
        public static readonly OpISubBorrowNodeFactory Instance = new OpISubBorrowNodeFactory();

        public OpISubBorrowNodeFactory():base(new ScriptNode()
        {
            Name = "ISubBorrow",
            Category = NodeCategory.Function,
            Type = "OpISubBorrow",
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