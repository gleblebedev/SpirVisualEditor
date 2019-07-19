using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupReserveWritePipePacketsNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupReserveWritePipePacketsNodeFactory Instance = new OpGroupReserveWritePipePacketsNodeFactory();

        public OpGroupReserveWritePipePacketsNodeFactory():base(new ScriptNode()
        {
            Name = "GroupReserveWritePipePackets",
            Category = NodeCategory.Function,
            Type = "OpGroupReserveWritePipePackets",
            InputPins =
            {
                new PinWithConnection("Pipe",null),
                new PinWithConnection("NumPackets",null),
                new PinWithConnection("PacketSize",null),
                new PinWithConnection("PacketAlignment",null),
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