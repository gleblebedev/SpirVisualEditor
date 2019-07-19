using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLifetimeStopNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLifetimeStopNodeFactory Instance = new OpLifetimeStopNodeFactory();

        public OpLifetimeStopNodeFactory():base(new ScriptNode()
        {
            Name = "LifetimeStop",
            Category = NodeCategory.Function,
            Type = "OpLifetimeStop",
            InputPins =
            {
                new PinWithConnection("Pointer",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}