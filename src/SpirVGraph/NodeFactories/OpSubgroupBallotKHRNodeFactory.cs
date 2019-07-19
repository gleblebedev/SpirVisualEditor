using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSubgroupBallotKHRNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSubgroupBallotKHRNodeFactory Instance = new OpSubgroupBallotKHRNodeFactory();

        public OpSubgroupBallotKHRNodeFactory():base(new ScriptNode()
        {
            Name = "SubgroupBallotKHR",
            Category = NodeCategory.Function,
            Type = "OpSubgroupBallotKHR",
            InputPins =
            {
                new PinWithConnection("Predicate",null),
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