using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSRemNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSRemNodeFactory Instance = new OpSRemNodeFactory();

        public OpSRemNodeFactory():base(new ScriptNode()
        {
            Name = "SRem",
            Category = NodeCategory.Function,
            Type = "OpSRem",
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