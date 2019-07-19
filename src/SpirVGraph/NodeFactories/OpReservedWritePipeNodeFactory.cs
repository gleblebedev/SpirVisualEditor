using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpReservedWritePipeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpReservedWritePipeNodeFactory Instance = new OpReservedWritePipeNodeFactory();

        public OpReservedWritePipeNodeFactory():base(new ScriptNode()
        {
            Name = "ReservedWritePipe",
            Category = NodeCategory.Function,
            Type = "OpReservedWritePipe",
            InputPins =
            {
                new PinWithConnection("Pipe",null),
                new PinWithConnection("ReserveId",null),
                new PinWithConnection("Index",null),
                new PinWithConnection("Pointer",null),
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