using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConvertSToFNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConvertSToFNodeFactory Instance = new OpConvertSToFNodeFactory();

        public OpConvertSToFNodeFactory():base(new ScriptNode()
        {
            Name = "ConvertSToF",
            Category = NodeCategory.Function,
            Type = "OpConvertSToF",
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