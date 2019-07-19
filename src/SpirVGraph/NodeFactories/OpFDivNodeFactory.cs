using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFDivNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFDivNodeFactory Instance = new OpFDivNodeFactory();

        public OpFDivNodeFactory():base(new ScriptNode()
        {
            Name = "FDiv",
            Category = NodeCategory.Function,
            Type = "OpFDiv",
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