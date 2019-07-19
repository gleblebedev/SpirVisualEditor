using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBitFieldSExtractNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBitFieldSExtractNodeFactory Instance = new OpBitFieldSExtractNodeFactory();

        public OpBitFieldSExtractNodeFactory():base(new ScriptNode()
        {
            Name = "BitFieldSExtract",
            Category = NodeCategory.Function,
            Type = "OpBitFieldSExtract",
            InputPins =
            {
                new PinWithConnection("Base",null),
                new PinWithConnection("Offset",null),
                new PinWithConnection("Count",null),
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