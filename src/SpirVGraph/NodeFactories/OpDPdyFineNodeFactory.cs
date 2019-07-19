using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDPdyFineNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDPdyFineNodeFactory Instance = new OpDPdyFineNodeFactory();

        public OpDPdyFineNodeFactory():base(new ScriptNode()
        {
            Name = "DPdyFine",
            Category = NodeCategory.Function,
            Type = "OpDPdyFine",
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