using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFRemNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFRemNodeFactory Instance = new OpFRemNodeFactory();

        public OpFRemNodeFactory():base(new ScriptNode()
        {
            Name = "FRem",
            Category = NodeCategory.Function,
            Type = "OpFRem",
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