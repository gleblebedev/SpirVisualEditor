using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGenericCastToPtrExplicitNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGenericCastToPtrExplicitNodeFactory Instance = new OpGenericCastToPtrExplicitNodeFactory();

        public OpGenericCastToPtrExplicitNodeFactory():base(new ScriptNode()
        {
            Name = "GenericCastToPtrExplicit",
            Category = NodeCategory.Function,
            Type = "OpGenericCastToPtrExplicit",
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