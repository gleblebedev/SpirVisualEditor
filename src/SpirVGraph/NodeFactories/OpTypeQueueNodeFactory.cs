using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeQueueNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeQueueNodeFactory Instance = new OpTypeQueueNodeFactory();

        public OpTypeQueueNodeFactory():base(new ScriptNode()
        {
            Name = "TypeQueue",
            Category = NodeCategory.Function,
            Type = "OpTypeQueue",
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