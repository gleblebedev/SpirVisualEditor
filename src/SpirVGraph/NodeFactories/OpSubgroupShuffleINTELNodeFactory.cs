using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupShuffleINTELNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupShuffleINTELNodeFactory Instance = new OpSubgroupShuffleINTELNodeFactory();

        public OpSubgroupShuffleINTELNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupShuffleINTEL",
            Category = NodeCategory.Function,
            Type = "OpSubgroupShuffleINTEL",
            InputPins =
            {
                new PinWithConnection("Data",null),
                new PinWithConnection("InvocationId",null),
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