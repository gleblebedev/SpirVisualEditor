using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpOrderedNodeFactory : AbstractNodeFactory
    {
        public static readonly OpOrderedNodeFactory Instance = new OpOrderedNodeFactory();

        public OpOrderedNodeFactory():base(new ScriptNode()
        {
            Name = "Ordered",
            Category = NodeCategory.Function,
            Type = "OpOrdered",
            InputPins =
            {
                new PinWithConnection("x",null),
                new PinWithConnection("y",null),
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