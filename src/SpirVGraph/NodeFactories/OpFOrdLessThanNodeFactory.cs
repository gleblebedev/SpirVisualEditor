using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFOrdLessThanNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFOrdLessThanNodeFactory Instance = new OpFOrdLessThanNodeFactory();

        public OpFOrdLessThanNodeFactory():base(new ScriptNode()
        {
            Name = "FOrdLessThan",
            Category = NodeCategory.Function,
            Type = "OpFOrdLessThan",
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