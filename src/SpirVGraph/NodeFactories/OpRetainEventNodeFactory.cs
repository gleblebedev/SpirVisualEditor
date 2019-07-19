using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpRetainEventNodeFactory : AbstractNodeFactory
    {
        public static readonly OpRetainEventNodeFactory Instance = new OpRetainEventNodeFactory();

        public OpRetainEventNodeFactory():base(new ScriptNode()
        {
            Name = "RetainEvent",
            Category = NodeCategory.Function,
            Type = "OpRetainEvent",
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