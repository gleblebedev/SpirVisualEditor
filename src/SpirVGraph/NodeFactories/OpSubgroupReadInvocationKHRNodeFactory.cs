using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupReadInvocationKHRNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupReadInvocationKHRNodeFactory Instance = new OpSubgroupReadInvocationKHRNodeFactory();

        public OpSubgroupReadInvocationKHRNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupReadInvocationKHR",
            Category = NodeCategory.Function,
            Type = "OpSubgroupReadInvocationKHR",
            InputPins =
            {
                new PinWithConnection("Value",null),
                new PinWithConnection("Index",null),
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