using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConvertUToFNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConvertUToFNodeFactory Instance = new OpConvertUToFNodeFactory();

        public OpConvertUToFNodeFactory():base(new ScriptNode()
        {
            Name = "ConvertUToF",
            Category = NodeCategory.Function,
            Type = "OpConvertUToF",
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