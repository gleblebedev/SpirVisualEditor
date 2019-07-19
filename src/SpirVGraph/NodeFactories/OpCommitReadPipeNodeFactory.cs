using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCommitReadPipeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCommitReadPipeNodeFactory Instance = new OpCommitReadPipeNodeFactory();

        public OpCommitReadPipeNodeFactory():base(new ScriptNode()
        {
            Name = "CommitReadPipe",
            Category = NodeCategory.Function,
            Type = "OpCommitReadPipe",
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