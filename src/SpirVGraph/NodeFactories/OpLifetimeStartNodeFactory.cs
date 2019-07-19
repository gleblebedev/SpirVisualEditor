using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLifetimeStartNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLifetimeStartNodeFactory Instance = new OpLifetimeStartNodeFactory();

        public OpLifetimeStartNodeFactory():base(new ScriptNode()
        {
            Name = "LifetimeStart",
            Category = NodeCategory.Function,
            Type = "OpLifetimeStart",
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