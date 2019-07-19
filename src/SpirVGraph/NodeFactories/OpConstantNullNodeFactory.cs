using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConstantNullNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConstantNullNodeFactory Instance = new OpConstantNullNodeFactory();

        public OpConstantNullNodeFactory():base(new ScriptNode()
        {
            Name = "ConstantNull",
            Category = NodeCategory.Function,
            Type = "OpConstantNull",
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