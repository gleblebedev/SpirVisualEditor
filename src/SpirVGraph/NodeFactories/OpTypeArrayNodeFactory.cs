using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeArrayNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeArrayNodeFactory Instance = new OpTypeArrayNodeFactory();

        public OpTypeArrayNodeFactory():base(new ScriptNode()
        {
            Name = "TypeArray",
            Category = NodeCategory.Function,
            Type = "OpTypeArray",
            InputPins =
            {
                new PinWithConnection("ElementType",null),
                new PinWithConnection("Length",null),
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