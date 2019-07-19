using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpAllNodeFactory : AbstractNodeFactory
    {
        public static readonly OpAllNodeFactory Instance = new OpAllNodeFactory();

        public OpAllNodeFactory():base(new ScriptNode()
        {
            Name = "All",
            Category = NodeCategory.Function,
            Type = "OpAll",
            InputPins =
            {
                new PinWithConnection("Vector",null),
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