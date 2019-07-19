using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpMemoryBarrierNodeFactory : AbstractNodeFactory
    {
        public static readonly OpMemoryBarrierNodeFactory Instance = new OpMemoryBarrierNodeFactory();

        public OpMemoryBarrierNodeFactory():base(new ScriptNode()
        {
            Name = "MemoryBarrier",
            Category = NodeCategory.Function,
            Type = "OpMemoryBarrier",
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