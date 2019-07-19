using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFwidthFineNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFwidthFineNodeFactory Instance = new OpFwidthFineNodeFactory();

        public OpFwidthFineNodeFactory():base(new ScriptNode()
        {
            Name = "FwidthFine",
            Category = NodeCategory.Function,
            Type = "OpFwidthFine",
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