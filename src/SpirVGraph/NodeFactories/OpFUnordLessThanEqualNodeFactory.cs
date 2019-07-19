using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFUnordLessThanEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFUnordLessThanEqualNodeFactory Instance = new OpFUnordLessThanEqualNodeFactory();

        public OpFUnordLessThanEqualNodeFactory():base(new ScriptNode()
        {
            Name = "FUnordLessThanEqual",
            Category = NodeCategory.Function,
            Type = "OpFUnordLessThanEqual",
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