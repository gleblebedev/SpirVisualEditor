using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupAllKHRNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupAllKHRNodeFactory Instance = new OpSubgroupAllKHRNodeFactory();

        public OpSubgroupAllKHRNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupAllKHR",
            Category = NodeCategory.Function,
            Type = "OpSubgroupAllKHR",
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