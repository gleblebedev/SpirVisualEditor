using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFUnordGreaterThanEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFUnordGreaterThanEqualNodeFactory Instance = new OpFUnordGreaterThanEqualNodeFactory();

        public OpFUnordGreaterThanEqualNodeFactory():base(new ScriptNode()
        {
            Name = "FUnordGreaterThanEqual",
            Category = NodeCategory.Function,
            Type = "OpFUnordGreaterThanEqual",
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