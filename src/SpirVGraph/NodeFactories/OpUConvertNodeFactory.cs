using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpUConvertNodeFactory : AbstractNodeFactory
    {
        public static readonly OpUConvertNodeFactory Instance = new OpUConvertNodeFactory();

        public OpUConvertNodeFactory():base(new ScriptNode()
        {
            Name = "UConvert",
            Category = NodeCategory.Function,
            Type = "OpUConvert",
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