using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupShuffleDownINTELNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupShuffleDownINTELNodeFactory Instance = new OpSubgroupShuffleDownINTELNodeFactory();

        public OpSubgroupShuffleDownINTELNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupShuffleDownINTEL",
            Category = NodeCategory.Function,
            Type = "OpSubgroupShuffleDownINTEL",
            InputPins =
            {
                new PinWithConnection("Current",null),
                new PinWithConnection("Next",null),
                new PinWithConnection("Delta",null),
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