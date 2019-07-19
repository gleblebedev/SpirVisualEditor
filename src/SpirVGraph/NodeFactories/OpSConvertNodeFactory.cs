using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSConvertNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSConvertNodeFactory Instance = new OpSConvertNodeFactory();

        public OpSConvertNodeFactory():base(new ScriptNode()
        {
            Name = "SConvert",
            Category = NodeCategory.Function,
            Type = "OpSConvert",
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