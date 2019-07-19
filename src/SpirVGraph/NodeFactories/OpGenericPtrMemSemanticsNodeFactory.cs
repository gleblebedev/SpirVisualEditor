using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGenericPtrMemSemanticsNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGenericPtrMemSemanticsNodeFactory Instance = new OpGenericPtrMemSemanticsNodeFactory();

        public OpGenericPtrMemSemanticsNodeFactory():base(new ScriptNode()
        {
            Name = "GenericPtrMemSemantics",
            Category = NodeCategory.Function,
            Type = "OpGenericPtrMemSemantics",
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