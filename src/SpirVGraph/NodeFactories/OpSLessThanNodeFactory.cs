using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSLessThanNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSLessThanNodeFactory Instance = new OpSLessThanNodeFactory();

        public OpSLessThanNodeFactory():base(new ScriptNode()
        {
            Name = "SLessThan",
            Category = NodeCategory.Function,
            Type = "OpSLessThan",
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