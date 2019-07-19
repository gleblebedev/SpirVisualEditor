using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupShuffleXorINTELNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupShuffleXorINTELNodeFactory Instance = new OpSubgroupShuffleXorINTELNodeFactory();

        public OpSubgroupShuffleXorINTELNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupShuffleXorINTEL",
            Category = NodeCategory.Function,
            Type = "OpSubgroupShuffleXorINTEL",
            InputPins =
            {
                new PinWithConnection("Data",null),
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