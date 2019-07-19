using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIsValidReserveIdNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIsValidReserveIdNodeFactory Instance = new OpIsValidReserveIdNodeFactory();

        public OpIsValidReserveIdNodeFactory():base(new ScriptNode()
        {
            Name = "IsValidReserveId",
            Category = NodeCategory.Function,
            Type = "OpIsValidReserveId",
            InputPins =
            {
                new PinWithConnection("ReserveId",null),
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