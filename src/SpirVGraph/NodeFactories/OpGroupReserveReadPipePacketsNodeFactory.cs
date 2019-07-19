using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupReserveReadPipePacketsNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupReserveReadPipePacketsNodeFactory Instance = new OpGroupReserveReadPipePacketsNodeFactory();

        public OpGroupReserveReadPipePacketsNodeFactory():base(new ScriptNode()
        {
            Name = "GroupReserveReadPipePackets",
            Category = NodeCategory.Function,
            Type = "OpGroupReserveReadPipePackets",
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