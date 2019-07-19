using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFConvertNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFConvertNodeFactory Instance = new OpFConvertNodeFactory();

        public OpFConvertNodeFactory():base(new ScriptNode()
        {
            Name = "FConvert",
            Category = NodeCategory.Function,
            Type = "OpFConvert",
            InputPins =
            {
                new PinWithConnection("FloatValue",null),
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