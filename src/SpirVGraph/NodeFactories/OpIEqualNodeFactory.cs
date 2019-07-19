using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIEqualNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIEqualNodeFactory Instance = new OpIEqualNodeFactory();

        public OpIEqualNodeFactory():base(new ScriptNode()
        {
            Name = "IEqual",
            Category = NodeCategory.Function,
            Type = "OpIEqual",
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