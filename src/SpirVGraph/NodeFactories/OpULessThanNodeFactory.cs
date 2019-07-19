using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpULessThanNodeFactory : AbstractNodeFactory
    {
        public static readonly OpULessThanNodeFactory Instance = new OpULessThanNodeFactory();

        public OpULessThanNodeFactory():base(new ScriptNode()
        {
            Name = "ULessThan",
            Category = NodeCategory.Function,
            Type = "OpULessThan",
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