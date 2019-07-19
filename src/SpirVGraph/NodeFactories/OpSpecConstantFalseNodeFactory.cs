using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSpecConstantFalseNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSpecConstantFalseNodeFactory Instance = new OpSpecConstantFalseNodeFactory();

        public OpSpecConstantFalseNodeFactory():base(new ScriptNode()
        {
            Name = "SpecConstantFalse",
            Category = NodeCategory.Function,
            Type = "OpSpecConstantFalse",
            InputPins =
            {
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