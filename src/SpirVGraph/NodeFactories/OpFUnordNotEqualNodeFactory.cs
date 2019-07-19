using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFUnordNotEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFUnordNotEqualNodeFactory Instance = new OpFUnordNotEqualNodeFactory();

        public OpFUnordNotEqualNodeFactory():base(new ScriptNode()
        {
            Name = "FUnordNotEqual",
            Category = NodeCategory.Function,
            Type = "OpFUnordNotEqual",
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