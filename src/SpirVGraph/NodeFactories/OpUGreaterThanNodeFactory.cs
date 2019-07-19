using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpUGreaterThanNodeFactory : AbstractNodeFactory
    {
        public static readonly OpUGreaterThanNodeFactory Instance = new OpUGreaterThanNodeFactory();

        public OpUGreaterThanNodeFactory():base(new ScriptNode()
        {
            Name = "UGreaterThan",
            Category = NodeCategory.Function,
            Type = "OpUGreaterThan",
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