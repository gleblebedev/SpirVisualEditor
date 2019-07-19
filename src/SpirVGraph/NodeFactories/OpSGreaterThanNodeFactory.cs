using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSGreaterThanNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSGreaterThanNodeFactory Instance = new OpSGreaterThanNodeFactory();

        public OpSGreaterThanNodeFactory():base(new ScriptNode()
        {
            Name = "SGreaterThan",
            Category = NodeCategory.Function,
            Type = "OpSGreaterThan",
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