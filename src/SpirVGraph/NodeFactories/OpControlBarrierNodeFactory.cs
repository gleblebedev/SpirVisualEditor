using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpControlBarrierNodeFactory : AbstractNodeFactory
    {
        public static readonly OpControlBarrierNodeFactory Instance = new OpControlBarrierNodeFactory();

        public OpControlBarrierNodeFactory():base(new ScriptNode()
        {
            Name = "ControlBarrier",
            Category = NodeCategory.Function,
            Type = "OpControlBarrier",
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