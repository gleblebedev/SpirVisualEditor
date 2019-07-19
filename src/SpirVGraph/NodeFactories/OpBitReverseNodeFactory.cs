using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBitReverseNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBitReverseNodeFactory Instance = new OpBitReverseNodeFactory();

        public OpBitReverseNodeFactory():base(new ScriptNode()
        {
            Name = "BitReverse",
            Category = NodeCategory.Function,
            Type = "OpBitReverse",
            InputPins =
            {
                new PinWithConnection("Base",null),
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