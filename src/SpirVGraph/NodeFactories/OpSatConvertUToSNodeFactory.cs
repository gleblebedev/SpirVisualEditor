using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSatConvertUToSNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSatConvertUToSNodeFactory Instance = new OpSatConvertUToSNodeFactory();

        public OpSatConvertUToSNodeFactory():base(new ScriptNode()
        {
            Name = "SatConvertUToS",
            Category = NodeCategory.Function,
            Type = "OpSatConvertUToS",
            InputPins =
            {
                new PinWithConnection("UnsignedValue",null),
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