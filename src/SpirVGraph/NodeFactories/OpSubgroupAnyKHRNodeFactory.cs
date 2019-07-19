using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupAnyKHRNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupAnyKHRNodeFactory Instance = new OpSubgroupAnyKHRNodeFactory();

        public OpSubgroupAnyKHRNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupAnyKHR",
            Category = NodeCategory.Function,
            Type = "OpSubgroupAnyKHR",
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