using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCreateUserEventNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCreateUserEventNodeFactory Instance = new OpCreateUserEventNodeFactory();

        public OpCreateUserEventNodeFactory():base(new ScriptNode()
        {
            Name = "CreateUserEvent",
            Category = NodeCategory.Function,
            Type = "OpCreateUserEvent",
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