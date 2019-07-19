using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGetNumPipePacketsNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGetNumPipePacketsNodeFactory Instance = new OpGetNumPipePacketsNodeFactory();

        public OpGetNumPipePacketsNodeFactory():base(new ScriptNode()
        {
            Name = "GetNumPipePackets",
            Category = NodeCategory.Function,
            Type = "OpGetNumPipePackets",
            InputPins =
            {
                new PinWithConnection("Pipe",null),
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