using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupAllNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupAllNodeFactory Instance = new OpGroupAllNodeFactory();

        public OpGroupAllNodeFactory():base(new ScriptNode()
        {
            Name = "GroupAll",
            Category = NodeCategory.Function,
            Type = "OpGroupAll",
            InputPins =
            {
                new PinWithConnection("Predicate",null),
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