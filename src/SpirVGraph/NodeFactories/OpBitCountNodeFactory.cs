using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBitCountNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBitCountNodeFactory Instance = new OpBitCountNodeFactory();

        public OpBitCountNodeFactory():base(new ScriptNode()
        {
            Name = "BitCount",
            Category = NodeCategory.Function,
            Type = "OpBitCount",
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