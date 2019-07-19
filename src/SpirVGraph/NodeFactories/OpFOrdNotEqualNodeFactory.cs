using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFOrdNotEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFOrdNotEqualNodeFactory Instance = new OpFOrdNotEqualNodeFactory();

        public OpFOrdNotEqualNodeFactory():base(new ScriptNode()
        {
            Name = "FOrdNotEqual",
            Category = NodeCategory.Function,
            Type = "OpFOrdNotEqual",
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