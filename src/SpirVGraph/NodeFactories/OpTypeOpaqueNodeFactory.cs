using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeOpaqueNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeOpaqueNodeFactory Instance = new OpTypeOpaqueNodeFactory();

        public OpTypeOpaqueNodeFactory():base(new ScriptNode()
        {
            Name = "TypeOpaque",
            Category = NodeCategory.Function,
            Type = "OpTypeOpaque",
            InputPins =
            {
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