using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSelectNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSelectNodeFactory Instance = new OpSelectNodeFactory();

        public OpSelectNodeFactory():base(new ScriptNode()
        {
            Name = "Select",
            Category = NodeCategory.Function,
            Type = "OpSelect",
            InputPins =
            {
                new PinWithConnection("Condition",null),
                new PinWithConnection("Object1",null),
                new PinWithConnection("Object2",null),
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