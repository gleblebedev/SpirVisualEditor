using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpShiftRightLogicalNodeFactory : AbstractNodeFactory
    {
        public static readonly OpShiftRightLogicalNodeFactory Instance = new OpShiftRightLogicalNodeFactory();

        public OpShiftRightLogicalNodeFactory():base(new ScriptNode()
        {
            Name = "ShiftRightLogical",
            Category = NodeCategory.Function,
            Type = "OpShiftRightLogical",
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