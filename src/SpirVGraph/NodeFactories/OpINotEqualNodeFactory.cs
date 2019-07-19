using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpINotEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpINotEqualNodeFactory Instance = new OpINotEqualNodeFactory();

        public OpINotEqualNodeFactory():base(new ScriptNode()
        {
            Name = "INotEqual",
            Category = NodeCategory.Function,
            Type = "OpINotEqual",
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