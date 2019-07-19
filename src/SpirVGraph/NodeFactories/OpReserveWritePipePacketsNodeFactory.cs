using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpReserveWritePipePacketsNodeFactory : AbstractNodeFactory
    {
        public static readonly OpReserveWritePipePacketsNodeFactory Instance = new OpReserveWritePipePacketsNodeFactory();

        public OpReserveWritePipePacketsNodeFactory():base(new ScriptNode()
        {
            Name = "ReserveWritePipePackets",
            Category = NodeCategory.Function,
            Type = "OpReserveWritePipePackets",
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