using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConvertFToUNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConvertFToUNodeFactory Instance = new OpConvertFToUNodeFactory();

        public OpConvertFToUNodeFactory():base(new ScriptNode()
        {
            Name = "ConvertFToU",
            Category = NodeCategory.Function,
            Type = "OpConvertFToU",
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