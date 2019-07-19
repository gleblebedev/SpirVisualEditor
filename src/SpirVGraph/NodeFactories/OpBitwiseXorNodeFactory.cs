using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBitwiseXorNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBitwiseXorNodeFactory Instance = new OpBitwiseXorNodeFactory();

        public OpBitwiseXorNodeFactory():base(new ScriptNode()
        {
            Name = "BitwiseXor",
            Category = NodeCategory.Function,
            Type = "OpBitwiseXor",
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