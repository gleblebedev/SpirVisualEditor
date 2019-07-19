using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBitFieldUExtractNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBitFieldUExtractNodeFactory Instance = new OpBitFieldUExtractNodeFactory();

        public OpBitFieldUExtractNodeFactory():base(new ScriptNode()
        {
            Name = "BitFieldUExtract",
            Category = NodeCategory.Function,
            Type = "OpBitFieldUExtract",
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