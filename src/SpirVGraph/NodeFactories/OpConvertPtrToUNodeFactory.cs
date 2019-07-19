using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConvertPtrToUNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConvertPtrToUNodeFactory Instance = new OpConvertPtrToUNodeFactory();

        public OpConvertPtrToUNodeFactory():base(new ScriptNode()
        {
            Name = "ConvertPtrToU",
            Category = NodeCategory.Function,
            Type = "OpConvertPtrToU",
            InputPins =
            {
                new PinWithConnection("Pointer",null),
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