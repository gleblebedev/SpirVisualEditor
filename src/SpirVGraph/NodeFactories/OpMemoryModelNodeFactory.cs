using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpMemoryModelNodeFactory : AbstractNodeFactory
    {
        public static readonly OpMemoryModelNodeFactory Instance = new OpMemoryModelNodeFactory();

        public OpMemoryModelNodeFactory():base(new ScriptNode()
        {
            Name = "MemoryModel",
            Category = NodeCategory.Function,
            Type = "OpMemoryModel",
            InputPins =
            {
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}