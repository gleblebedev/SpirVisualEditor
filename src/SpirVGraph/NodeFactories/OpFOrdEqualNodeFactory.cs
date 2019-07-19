using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFOrdEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFOrdEqualNodeFactory Instance = new OpFOrdEqualNodeFactory();

        public OpFOrdEqualNodeFactory():base(new ScriptNode()
        {
            Name = "FOrdEqual",
            Category = NodeCategory.Function,
            Type = "OpFOrdEqual",
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