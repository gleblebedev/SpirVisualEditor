using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConstantTrueNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConstantTrueNodeFactory Instance = new OpConstantTrueNodeFactory();

        public OpConstantTrueNodeFactory():base(new ScriptNode()
        {
            Name = "ConstantTrue",
            Category = NodeCategory.Function,
            Type = "OpConstantTrue",
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