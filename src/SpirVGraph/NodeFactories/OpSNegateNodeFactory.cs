using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSNegateNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSNegateNodeFactory Instance = new OpSNegateNodeFactory();

        public OpSNegateNodeFactory():base(new ScriptNode()
        {
            Name = "SNegate",
            Category = NodeCategory.Function,
            Type = "OpSNegate",
            InputPins =
            {
                new PinWithConnection("Operand",null),
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