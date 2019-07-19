using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpVariableNodeFactory : AbstractNodeFactory
    {
        public static readonly OpVariableNodeFactory Instance = new OpVariableNodeFactory();

        public OpVariableNodeFactory():base(new ScriptNode()
        {
            Name = "Variable",
            Category = NodeCategory.Function,
            Type = "OpVariable",
            InputPins =
            {
                new PinWithConnection("Initializer",null),
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