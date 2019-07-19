using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpPtrCastToGenericNodeFactory : AbstractNodeFactory
    {
        public static readonly OpPtrCastToGenericNodeFactory Instance = new OpPtrCastToGenericNodeFactory();

        public OpPtrCastToGenericNodeFactory():base(new ScriptNode()
        {
            Name = "PtrCastToGeneric",
            Category = NodeCategory.Function,
            Type = "OpPtrCastToGeneric",
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