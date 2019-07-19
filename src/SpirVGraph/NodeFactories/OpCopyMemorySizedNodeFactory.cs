using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCopyMemorySizedNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCopyMemorySizedNodeFactory Instance = new OpCopyMemorySizedNodeFactory();

        public OpCopyMemorySizedNodeFactory():base(new ScriptNode()
        {
            Name = "CopyMemorySized",
            Category = NodeCategory.Function,
            Type = "OpCopyMemorySized",
            InputPins =
            {
                new PinWithConnection("Target",null),
                new PinWithConnection("Source",null),
                new PinWithConnection("Size",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}