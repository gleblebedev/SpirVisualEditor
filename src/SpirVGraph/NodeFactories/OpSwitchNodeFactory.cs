using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSwitchNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSwitchNodeFactory Instance = new OpSwitchNodeFactory();

        public OpSwitchNodeFactory():base(new ScriptNode()
        {
            Name = "Switch",
            Category = NodeCategory.Function,
            Type = "OpSwitch",
            InputPins =
            {
                new PinWithConnection("Selector",null),
                new PinWithConnection("Default",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}