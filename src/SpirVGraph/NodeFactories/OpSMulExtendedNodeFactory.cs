using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSMulExtendedNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSMulExtendedNodeFactory Instance = new OpSMulExtendedNodeFactory();

        public OpSMulExtendedNodeFactory():base(new ScriptNode()
        {
            Name = "SMulExtended",
            Category = NodeCategory.Function,
            Type = "OpSMulExtended",
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