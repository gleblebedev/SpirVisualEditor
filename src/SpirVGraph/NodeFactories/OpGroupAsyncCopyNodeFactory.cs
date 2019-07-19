using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupAsyncCopyNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupAsyncCopyNodeFactory Instance = new OpGroupAsyncCopyNodeFactory();

        public OpGroupAsyncCopyNodeFactory():base(new ScriptNode()
        {
            Name = "GroupAsyncCopy",
            Category = NodeCategory.Function,
            Type = "OpGroupAsyncCopy",
            InputPins =
            {
                new PinWithConnection("Destination",null),
                new PinWithConnection("Source",null),
                new PinWithConnection("NumElements",null),
                new PinWithConnection("Stride",null),
                new PinWithConnection("Event",null),
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