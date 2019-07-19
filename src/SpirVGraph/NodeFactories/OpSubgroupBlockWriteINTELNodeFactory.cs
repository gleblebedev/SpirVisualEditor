using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupBlockWriteINTELNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupBlockWriteINTELNodeFactory Instance = new OpSubgroupBlockWriteINTELNodeFactory();

        public OpSubgroupBlockWriteINTELNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupBlockWriteINTEL",
            Category = NodeCategory.Function,
            Type = "OpSubgroupBlockWriteINTEL",
            InputPins =
            {
                new PinWithConnection("Ptr",null),
                new PinWithConnection("Data",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}