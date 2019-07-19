using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFMulNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFMulNodeFactory Instance = new OpFMulNodeFactory();

        public OpFMulNodeFactory():base(new ScriptNode()
        {
            Name = "FMul",
            Category = NodeCategory.Function,
            Type = "OpFMul",
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