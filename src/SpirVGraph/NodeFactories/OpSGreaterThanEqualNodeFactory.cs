using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSGreaterThanEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSGreaterThanEqualNodeFactory Instance = new OpSGreaterThanEqualNodeFactory();

        public OpSGreaterThanEqualNodeFactory():base(new ScriptNode()
        {
            Name = "SGreaterThanEqual",
            Category = NodeCategory.Function,
            Type = "OpSGreaterThanEqual",
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