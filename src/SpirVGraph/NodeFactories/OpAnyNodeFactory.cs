using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAnyNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAnyNodeFactory Instance = new OpAnyNodeFactory();

        public OpAnyNodeFactory():base(new ScriptNode()
        {
            Name = "Any",
            Category = NodeCategory.Function,
            Type = "OpAny",
            InputPins =
            {
                new PinWithConnection("Vector",null),
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