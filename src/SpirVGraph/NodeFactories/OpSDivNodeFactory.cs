using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSDivNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSDivNodeFactory Instance = new OpSDivNodeFactory();

        public OpSDivNodeFactory():base(new ScriptNode()
        {
            Name = "SDiv",
            Category = NodeCategory.Function,
            Type = "OpSDiv",
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