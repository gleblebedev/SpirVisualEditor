using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIAddNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIAddNodeFactory Instance = new OpIAddNodeFactory();

        public OpIAddNodeFactory():base(new ScriptNode()
        {
            Name = "IAdd",
            Category = NodeCategory.Function,
            Type = "OpIAdd",
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