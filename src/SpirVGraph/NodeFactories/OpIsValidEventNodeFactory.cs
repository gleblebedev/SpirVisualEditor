using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIsValidEventNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIsValidEventNodeFactory Instance = new OpIsValidEventNodeFactory();

        public OpIsValidEventNodeFactory():base(new ScriptNode()
        {
            Name = "IsValidEvent",
            Category = NodeCategory.Function,
            Type = "OpIsValidEvent",
            InputPins =
            {
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