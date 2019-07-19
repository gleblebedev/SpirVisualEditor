using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFOrdLessThanEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFOrdLessThanEqualNodeFactory Instance = new OpFOrdLessThanEqualNodeFactory();

        public OpFOrdLessThanEqualNodeFactory():base(new ScriptNode()
        {
            Name = "FOrdLessThanEqual",
            Category = NodeCategory.Function,
            Type = "OpFOrdLessThanEqual",
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