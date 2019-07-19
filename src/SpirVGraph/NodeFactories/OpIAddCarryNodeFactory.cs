using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIAddCarryNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIAddCarryNodeFactory Instance = new OpIAddCarryNodeFactory();

        public OpIAddCarryNodeFactory():base(new ScriptNode()
        {
            Name = "IAddCarry",
            Category = NodeCategory.Function,
            Type = "OpIAddCarry",
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