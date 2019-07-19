using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupCommitReadPipeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupCommitReadPipeNodeFactory Instance = new OpGroupCommitReadPipeNodeFactory();

        public OpGroupCommitReadPipeNodeFactory():base(new ScriptNode()
        {
            Name = "GroupCommitReadPipe",
            Category = NodeCategory.Function,
            Type = "OpGroupCommitReadPipe",
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