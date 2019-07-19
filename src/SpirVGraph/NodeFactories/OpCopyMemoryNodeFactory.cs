using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCopyMemoryNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCopyMemoryNodeFactory Instance = new OpCopyMemoryNodeFactory();

        public OpCopyMemoryNodeFactory():base(new ScriptNode()
        {
            Name = "CopyMemory",
            Category = NodeCategory.Function,
            Type = "OpCopyMemory",
            InputPins =
            {
                new PinWithConnection("Target",null),
                new PinWithConnection("Source",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}