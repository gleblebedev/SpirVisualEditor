using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeEventNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeEventNodeFactory Instance = new OpTypeEventNodeFactory();

        public OpTypeEventNodeFactory():base(new ScriptNode()
        {
            Name = "TypeEvent",
            Category = NodeCategory.Function,
            Type = "OpTypeEvent",
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