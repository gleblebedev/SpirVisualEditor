using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupBroadcastNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupBroadcastNodeFactory Instance = new OpGroupBroadcastNodeFactory();

        public OpGroupBroadcastNodeFactory():base(new ScriptNode()
        {
            Name = "GroupBroadcast",
            Category = NodeCategory.Function,
            Type = "OpGroupBroadcast",
            InputPins =
            {
                new PinWithConnection("Value",null),
                new PinWithConnection("LocalId",null),
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