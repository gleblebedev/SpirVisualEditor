using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBitwiseOrNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBitwiseOrNodeFactory Instance = new OpBitwiseOrNodeFactory();

        public OpBitwiseOrNodeFactory():base(new ScriptNode()
        {
            Name = "BitwiseOr",
            Category = NodeCategory.Function,
            Type = "OpBitwiseOr",
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