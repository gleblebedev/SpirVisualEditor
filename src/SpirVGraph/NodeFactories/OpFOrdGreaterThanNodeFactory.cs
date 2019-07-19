using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFOrdGreaterThanNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFOrdGreaterThanNodeFactory Instance = new OpFOrdGreaterThanNodeFactory();

        public OpFOrdGreaterThanNodeFactory():base(new ScriptNode()
        {
            Name = "FOrdGreaterThan",
            Category = NodeCategory.Function,
            Type = "OpFOrdGreaterThan",
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