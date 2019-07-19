using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpUnorderedNodeFactory : AbstractNodeFactory
    {
        public static readonly OpUnorderedNodeFactory Instance = new OpUnorderedNodeFactory();

        public OpUnorderedNodeFactory():base(new ScriptNode()
        {
            Name = "Unordered",
            Category = NodeCategory.Function,
            Type = "OpUnordered",
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