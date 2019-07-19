using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeForwardPointerNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeForwardPointerNodeFactory Instance = new OpTypeForwardPointerNodeFactory();

        public OpTypeForwardPointerNodeFactory():base(new ScriptNode()
        {
            Name = "TypeForwardPointer",
            Category = NodeCategory.Function,
            Type = "OpTypeForwardPointer",
            InputPins =
            {
                new PinWithConnection("PointerType",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}