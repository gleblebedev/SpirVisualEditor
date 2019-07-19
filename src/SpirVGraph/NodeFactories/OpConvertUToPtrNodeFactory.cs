using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConvertUToPtrNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConvertUToPtrNodeFactory Instance = new OpConvertUToPtrNodeFactory();

        public OpConvertUToPtrNodeFactory():base(new ScriptNode()
        {
            Name = "ConvertUToPtr",
            Category = NodeCategory.Function,
            Type = "OpConvertUToPtr",
            InputPins =
            {
                new PinWithConnection("IntegerValue",null),
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