using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpUGreaterThanEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpUGreaterThanEqualNodeFactory Instance = new OpUGreaterThanEqualNodeFactory();

        public OpUGreaterThanEqualNodeFactory():base(new ScriptNode()
        {
            Name = "UGreaterThanEqual",
            Category = NodeCategory.Function,
            Type = "OpUGreaterThanEqual",
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