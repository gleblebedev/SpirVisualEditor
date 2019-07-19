using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFUnordGreaterThanNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFUnordGreaterThanNodeFactory Instance = new OpFUnordGreaterThanNodeFactory();

        public OpFUnordGreaterThanNodeFactory():base(new ScriptNode()
        {
            Name = "FUnordGreaterThan",
            Category = NodeCategory.Function,
            Type = "OpFUnordGreaterThan",
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