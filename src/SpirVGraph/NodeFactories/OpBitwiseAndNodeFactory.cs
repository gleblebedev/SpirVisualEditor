using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBitwiseAndNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBitwiseAndNodeFactory Instance = new OpBitwiseAndNodeFactory();

        public OpBitwiseAndNodeFactory():base(new ScriptNode()
        {
            Name = "BitwiseAnd",
            Category = NodeCategory.Function,
            Type = "OpBitwiseAnd",
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