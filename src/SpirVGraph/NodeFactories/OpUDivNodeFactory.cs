using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpUDivNodeFactory : AbstractNodeFactory
    {
        public static readonly OpUDivNodeFactory Instance = new OpUDivNodeFactory();

        public OpUDivNodeFactory():base(new ScriptNode()
        {
            Name = "UDiv",
            Category = NodeCategory.Function,
            Type = "OpUDiv",
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