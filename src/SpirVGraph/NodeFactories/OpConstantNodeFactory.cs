using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConstantNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConstantNodeFactory Instance = new OpConstantNodeFactory();

        public OpConstantNodeFactory():base(new ScriptNode()
        {
            Name = "Constant",
            Category = NodeCategory.Function,
            Type = "OpConstant",
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