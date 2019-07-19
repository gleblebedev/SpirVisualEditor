using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGenericCastToPtrNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGenericCastToPtrNodeFactory Instance = new OpGenericCastToPtrNodeFactory();

        public OpGenericCastToPtrNodeFactory():base(new ScriptNode()
        {
            Name = "GenericCastToPtr",
            Category = NodeCategory.Function,
            Type = "OpGenericCastToPtr",
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