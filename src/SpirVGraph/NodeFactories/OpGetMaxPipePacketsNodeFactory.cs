using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGetMaxPipePacketsNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGetMaxPipePacketsNodeFactory Instance = new OpGetMaxPipePacketsNodeFactory();

        public OpGetMaxPipePacketsNodeFactory():base(new ScriptNode()
        {
            Name = "GetMaxPipePackets",
            Category = NodeCategory.Function,
            Type = "OpGetMaxPipePackets",
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