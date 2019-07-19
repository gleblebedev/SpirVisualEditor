using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpReserveReadPipePacketsNodeFactory : AbstractNodeFactory
    {
        public static readonly OpReserveReadPipePacketsNodeFactory Instance = new OpReserveReadPipePacketsNodeFactory();

        public OpReserveReadPipePacketsNodeFactory():base(new ScriptNode()
        {
            Name = "ReserveReadPipePackets",
            Category = NodeCategory.Function,
            Type = "OpReserveReadPipePackets",
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