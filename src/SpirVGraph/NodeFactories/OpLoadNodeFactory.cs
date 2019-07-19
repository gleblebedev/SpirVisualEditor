using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLoadNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLoadNodeFactory Instance = new OpLoadNodeFactory();

        public OpLoadNodeFactory():base(new ScriptNode()
        {
            Name = "Load",
            Category = NodeCategory.Function,
            Type = "OpLoad",
            InputPins =
            {
                new PinWithConnection("Pointer",null),
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