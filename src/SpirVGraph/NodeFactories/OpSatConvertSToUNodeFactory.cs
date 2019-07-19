using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSatConvertSToUNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSatConvertSToUNodeFactory Instance = new OpSatConvertSToUNodeFactory();

        public OpSatConvertSToUNodeFactory():base(new ScriptNode()
        {
            Name = "SatConvertSToU",
            Category = NodeCategory.Function,
            Type = "OpSatConvertSToU",
            InputPins =
            {
                new PinWithConnection("SignedValue",null),
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