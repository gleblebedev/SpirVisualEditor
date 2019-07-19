using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupImageBlockWriteINTELNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupImageBlockWriteINTELNodeFactory Instance = new OpSubgroupImageBlockWriteINTELNodeFactory();

        public OpSubgroupImageBlockWriteINTELNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupImageBlockWriteINTEL",
            Category = NodeCategory.Function,
            Type = "OpSubgroupImageBlockWriteINTEL",
            InputPins =
            {
                new PinWithConnection("Image",null),
                new PinWithConnection("Coordinate",null),
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