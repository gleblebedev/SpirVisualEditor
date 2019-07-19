using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupCommitWritePipeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupCommitWritePipeNodeFactory Instance = new OpGroupCommitWritePipeNodeFactory();

        public OpGroupCommitWritePipeNodeFactory():base(new ScriptNode()
        {
            Name = "GroupCommitWritePipe",
            Category = NodeCategory.Function,
            Type = "OpGroupCommitWritePipe",
            InputPins =
            {
                new PinWithConnection("Pipe",null),
                new PinWithConnection("ReserveId",null),
                new PinWithConnection("PacketSize",null),
                new PinWithConnection("PacketAlignment",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}