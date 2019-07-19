using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFUnordLessThanNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFUnordLessThanNodeFactory Instance = new OpFUnordLessThanNodeFactory();

        public OpFUnordLessThanNodeFactory():base(new ScriptNode()
        {
            Name = "FUnordLessThan",
            Category = NodeCategory.Function,
            Type = "OpFUnordLessThan",
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