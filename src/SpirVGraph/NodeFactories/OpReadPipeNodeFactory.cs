using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpReadPipeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpReadPipeNodeFactory Instance = new OpReadPipeNodeFactory();

        public OpReadPipeNodeFactory():base(new ScriptNode()
        {
            Name = "ReadPipe",
            Category = NodeCategory.Function,
            Type = "OpReadPipe",
            InputPins =
            {
                new PinWithConnection("Pipe",null),
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