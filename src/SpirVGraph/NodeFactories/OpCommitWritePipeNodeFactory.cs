using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCommitWritePipeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCommitWritePipeNodeFactory Instance = new OpCommitWritePipeNodeFactory();

        public OpCommitWritePipeNodeFactory():base(new ScriptNode()
        {
            Name = "CommitWritePipe",
            Category = NodeCategory.Function,
            Type = "OpCommitWritePipe",
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