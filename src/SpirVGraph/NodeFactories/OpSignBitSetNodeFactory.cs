using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSignBitSetNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSignBitSetNodeFactory Instance = new OpSignBitSetNodeFactory();

        public OpSignBitSetNodeFactory():base(new ScriptNode()
        {
            Name = "SignBitSet",
            Category = NodeCategory.Function,
            Type = "OpSignBitSet",
            InputPins =
            {
                new PinWithConnection("x",null),
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