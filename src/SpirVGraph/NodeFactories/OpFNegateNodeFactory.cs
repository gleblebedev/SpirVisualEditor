using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFNegateNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFNegateNodeFactory Instance = new OpFNegateNodeFactory();

        public OpFNegateNodeFactory():base(new ScriptNode()
        {
            Name = "FNegate",
            Category = NodeCategory.Function,
            Type = "OpFNegate",
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