using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupImageBlockReadINTELNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupImageBlockReadINTELNodeFactory Instance = new OpSubgroupImageBlockReadINTELNodeFactory();

        public OpSubgroupImageBlockReadINTELNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupImageBlockReadINTEL",
            Category = NodeCategory.Function,
            Type = "OpSubgroupImageBlockReadINTEL",
            InputPins =
            {
                new PinWithConnection("Image",null),
                new PinWithConnection("Coordinate",null),
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