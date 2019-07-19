using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupFirstInvocationKHRNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupFirstInvocationKHRNodeFactory Instance = new OpSubgroupFirstInvocationKHRNodeFactory();

        public OpSubgroupFirstInvocationKHRNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupFirstInvocationKHR",
            Category = NodeCategory.Function,
            Type = "OpSubgroupFirstInvocationKHR",
            InputPins =
            {
                new PinWithConnection("Value",null),
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