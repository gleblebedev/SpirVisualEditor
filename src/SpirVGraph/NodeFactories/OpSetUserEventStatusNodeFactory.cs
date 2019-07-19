using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSetUserEventStatusNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSetUserEventStatusNodeFactory Instance = new OpSetUserEventStatusNodeFactory();

        public OpSetUserEventStatusNodeFactory():base(new ScriptNode()
        {
            Name = "SetUserEventStatus",
            Category = NodeCategory.Function,
            Type = "OpSetUserEventStatus",
            InputPins =
            {
                new PinWithConnection("Event",null),
                new PinWithConnection("Status",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}