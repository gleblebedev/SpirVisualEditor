using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpISubNodeFactory : AbstractNodeFactory
    {
        public static readonly OpISubNodeFactory Instance = new OpISubNodeFactory();

        public OpISubNodeFactory():base(new ScriptNode()
        {
            Name = "ISub",
            Category = NodeCategory.Function,
            Type = "OpISub",
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