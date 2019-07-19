using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupBlockReadINTELNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupBlockReadINTELNodeFactory Instance = new OpSubgroupBlockReadINTELNodeFactory();

        public OpSubgroupBlockReadINTELNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupBlockReadINTEL",
            Category = NodeCategory.Function,
            Type = "OpSubgroupBlockReadINTEL",
            InputPins =
            {
                new PinWithConnection("Ptr",null),
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