using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupShuffleUpINTELNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupShuffleUpINTELNodeFactory Instance = new OpSubgroupShuffleUpINTELNodeFactory();

        public OpSubgroupShuffleUpINTELNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupShuffleUpINTEL",
            Category = NodeCategory.Function,
            Type = "OpSubgroupShuffleUpINTEL",
            InputPins =
            {
                new PinWithConnection("Previous",null),
                new PinWithConnection("Current",null),
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