using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupAllEqualKHRNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupAllEqualKHRNodeFactory Instance = new OpSubgroupAllEqualKHRNodeFactory();

        public OpSubgroupAllEqualKHRNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupAllEqualKHR",
            Category = NodeCategory.Function,
            Type = "OpSubgroupAllEqualKHR",
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