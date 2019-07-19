using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpEnqueueMarkerNodeFactory : AbstractNodeFactory
    {
        public static readonly OpEnqueueMarkerNodeFactory Instance = new OpEnqueueMarkerNodeFactory();

        public OpEnqueueMarkerNodeFactory():base(new ScriptNode()
        {
            Name = "EnqueueMarker",
            Category = NodeCategory.Function,
            Type = "OpEnqueueMarker",
            InputPins =
            {
                new PinWithConnection("Queue",null),
                new PinWithConnection("NumEvents",null),
                new PinWithConnection("WaitEvents",null),
                new PinWithConnection("RetEvent",null),
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