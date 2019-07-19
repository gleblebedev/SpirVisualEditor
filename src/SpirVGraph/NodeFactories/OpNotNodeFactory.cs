using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpNotNodeFactory : AbstractNodeFactory
    {
        public static readonly OpNotNodeFactory Instance = new OpNotNodeFactory();

        public OpNotNodeFactory():base(new ScriptNode()
        {
            Name = "Not",
            Category = NodeCategory.Function,
            Type = "OpNot",
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