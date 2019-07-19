using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFAddNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFAddNodeFactory Instance = new OpFAddNodeFactory();

        public OpFAddNodeFactory():base(new ScriptNode()
        {
            Name = "FAdd",
            Category = NodeCategory.Function,
            Type = "OpFAdd",
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