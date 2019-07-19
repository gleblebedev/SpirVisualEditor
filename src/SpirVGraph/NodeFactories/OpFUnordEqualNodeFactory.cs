using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFUnordEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFUnordEqualNodeFactory Instance = new OpFUnordEqualNodeFactory();

        public OpFUnordEqualNodeFactory():base(new ScriptNode()
        {
            Name = "FUnordEqual",
            Category = NodeCategory.Function,
            Type = "OpFUnordEqual",
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