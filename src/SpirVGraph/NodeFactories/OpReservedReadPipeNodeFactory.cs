using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpReservedReadPipeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpReservedReadPipeNodeFactory Instance = new OpReservedReadPipeNodeFactory();

        public OpReservedReadPipeNodeFactory():base(new ScriptNode()
        {
            Name = "ReservedReadPipe",
            Category = NodeCategory.Function,
            Type = "OpReservedReadPipe",
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