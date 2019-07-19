using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpShiftLeftLogicalNodeFactory : AbstractNodeFactory
    {
        public static readonly OpShiftLeftLogicalNodeFactory Instance = new OpShiftLeftLogicalNodeFactory();

        public OpShiftLeftLogicalNodeFactory():base(new ScriptNode()
        {
            Name = "ShiftLeftLogical",
            Category = NodeCategory.Function,
            Type = "OpShiftLeftLogical",
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