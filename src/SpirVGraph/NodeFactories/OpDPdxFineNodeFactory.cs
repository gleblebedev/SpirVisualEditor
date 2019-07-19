using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDPdxFineNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDPdxFineNodeFactory Instance = new OpDPdxFineNodeFactory();

        public OpDPdxFineNodeFactory():base(new ScriptNode()
        {
            Name = "DPdxFine",
            Category = NodeCategory.Function,
            Type = "OpDPdxFine",
            InputPins =
            {
                new PinWithConnection("P",null),
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