using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConvertFToSNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConvertFToSNodeFactory Instance = new OpConvertFToSNodeFactory();

        public OpConvertFToSNodeFactory():base(new ScriptNode()
        {
            Name = "ConvertFToS",
            Category = NodeCategory.Function,
            Type = "OpConvertFToS",
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