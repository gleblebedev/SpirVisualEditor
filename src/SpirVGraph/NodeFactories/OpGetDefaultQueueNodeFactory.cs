using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGetDefaultQueueNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGetDefaultQueueNodeFactory Instance = new OpGetDefaultQueueNodeFactory();

        public OpGetDefaultQueueNodeFactory():base(new ScriptNode()
        {
            Name = "GetDefaultQueue",
            Category = NodeCategory.Function,
            Type = "OpGetDefaultQueue",
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