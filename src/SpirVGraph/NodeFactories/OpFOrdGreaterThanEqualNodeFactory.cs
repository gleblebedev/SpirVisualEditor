using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFOrdGreaterThanEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFOrdGreaterThanEqualNodeFactory Instance = new OpFOrdGreaterThanEqualNodeFactory();

        public OpFOrdGreaterThanEqualNodeFactory():base(new ScriptNode()
        {
            Name = "FOrdGreaterThanEqual",
            Category = NodeCategory.Function,
            Type = "OpFOrdGreaterThanEqual",
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