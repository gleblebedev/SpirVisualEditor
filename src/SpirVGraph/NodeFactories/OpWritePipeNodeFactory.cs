using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpWritePipeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpWritePipeNodeFactory Instance = new OpWritePipeNodeFactory();

        public OpWritePipeNodeFactory():base(new ScriptNode()
        {
            Name = "WritePipe",
            Category = NodeCategory.Function,
            Type = "OpWritePipe",
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