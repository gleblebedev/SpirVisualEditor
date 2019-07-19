using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConstantFalseNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConstantFalseNodeFactory Instance = new OpConstantFalseNodeFactory();

        public OpConstantFalseNodeFactory():base(new ScriptNode()
        {
            Name = "ConstantFalse",
            Category = NodeCategory.Function,
            Type = "OpConstantFalse",
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