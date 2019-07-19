using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFwidthNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFwidthNodeFactory Instance = new OpFwidthNodeFactory();

        public OpFwidthNodeFactory():base(new ScriptNode()
        {
            Name = "Fwidth",
            Category = NodeCategory.Function,
            Type = "OpFwidth",
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