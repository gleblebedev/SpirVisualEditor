using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupAnyNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupAnyNodeFactory Instance = new OpGroupAnyNodeFactory();

        public OpGroupAnyNodeFactory():base(new ScriptNode()
        {
            Name = "GroupAny",
            Category = NodeCategory.Function,
            Type = "OpGroupAny",
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