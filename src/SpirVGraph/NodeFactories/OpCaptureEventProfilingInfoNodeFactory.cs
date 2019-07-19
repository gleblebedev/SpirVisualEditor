using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCaptureEventProfilingInfoNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCaptureEventProfilingInfoNodeFactory Instance = new OpCaptureEventProfilingInfoNodeFactory();

        public OpCaptureEventProfilingInfoNodeFactory():base(new ScriptNode()
        {
            Name = "CaptureEventProfilingInfo",
            Category = NodeCategory.Function,
            Type = "OpCaptureEventProfilingInfo",
            InputPins =
            {
                new PinWithConnection("Event",null),
                new PinWithConnection("ProfilingInfo",null),
                new PinWithConnection("Value",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}