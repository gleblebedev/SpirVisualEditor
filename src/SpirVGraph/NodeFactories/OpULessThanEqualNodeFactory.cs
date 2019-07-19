using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpULessThanEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpULessThanEqualNodeFactory Instance = new OpULessThanEqualNodeFactory();

        public OpULessThanEqualNodeFactory():base(new ScriptNode()
        {
            Name = "ULessThanEqual",
            Category = NodeCategory.Function,
            Type = "OpULessThanEqual",
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