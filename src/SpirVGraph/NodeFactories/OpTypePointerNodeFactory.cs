using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypePointerNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypePointerNodeFactory Instance = new OpTypePointerNodeFactory();

        public OpTypePointerNodeFactory():base(new ScriptNode()
        {
            Name = "TypePointer",
            Category = NodeCategory.Function,
            Type = "OpTypePointer",
            InputPins =
            {
                new PinWithConnection("Type",null),
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