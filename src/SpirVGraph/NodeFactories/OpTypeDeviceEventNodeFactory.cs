using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeDeviceEventNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeDeviceEventNodeFactory Instance = new OpTypeDeviceEventNodeFactory();

        public OpTypeDeviceEventNodeFactory():base(new ScriptNode()
        {
            Name = "TypeDeviceEvent",
            Category = NodeCategory.Function,
            Type = "OpTypeDeviceEvent",
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