using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSLessThanEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSLessThanEqualNodeFactory Instance = new OpSLessThanEqualNodeFactory();

        public OpSLessThanEqualNodeFactory():base(new ScriptNode()
        {
            Name = "SLessThanEqual",
            Category = NodeCategory.Function,
            Type = "OpSLessThanEqual",
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