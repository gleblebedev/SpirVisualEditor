using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeRuntimeArrayNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeRuntimeArrayNodeFactory Instance = new OpTypeRuntimeArrayNodeFactory();

        public OpTypeRuntimeArrayNodeFactory():base(new ScriptNode()
        {
            Name = "TypeRuntimeArray",
            Category = NodeCategory.Function,
            Type = "OpTypeRuntimeArray",
            InputPins =
            {
                new PinWithConnection("ElementType",null),
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