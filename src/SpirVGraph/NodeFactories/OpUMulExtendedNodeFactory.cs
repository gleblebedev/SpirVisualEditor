using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpUMulExtendedNodeFactory : AbstractNodeFactory
    {
        public static readonly OpUMulExtendedNodeFactory Instance = new OpUMulExtendedNodeFactory();

        public OpUMulExtendedNodeFactory():base(new ScriptNode()
        {
            Name = "UMulExtended",
            Category = NodeCategory.Function,
            Type = "OpUMulExtended",
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