using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupWaitEventsNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupWaitEventsNodeFactory Instance = new OpGroupWaitEventsNodeFactory();

        public OpGroupWaitEventsNodeFactory():base(new ScriptNode()
        {
            Name = "GroupWaitEvents",
            Category = NodeCategory.Function,
            Type = "OpGroupWaitEvents",
            InputPins =
            {
                new PinWithConnection("NumEvents",null),
                new PinWithConnection("EventsList",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}