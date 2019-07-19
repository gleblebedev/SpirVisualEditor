using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpShiftRightArithmeticNodeFactory : AbstractNodeFactory
    {
        public static readonly OpShiftRightArithmeticNodeFactory Instance = new OpShiftRightArithmeticNodeFactory();

        public OpShiftRightArithmeticNodeFactory():base(new ScriptNode()
        {
            Name = "ShiftRightArithmetic",
            Category = NodeCategory.Function,
            Type = "OpShiftRightArithmetic",
            InputPins =
            {
                new PinWithConnection("Base",null),
                new PinWithConnection("Shift",null),
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