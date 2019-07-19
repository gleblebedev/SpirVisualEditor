using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpReleaseEventNodeFactory : AbstractNodeFactory
    {
        public static readonly OpReleaseEventNodeFactory Instance = new OpReleaseEventNodeFactory();

        public OpReleaseEventNodeFactory():base(new ScriptNode()
        {
            Name = "ReleaseEvent",
            Category = NodeCategory.Function,
            Type = "OpReleaseEvent",
            InputPins =
            {
                new PinWithConnection("Event",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}