using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeBoolNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeBoolNodeFactory Instance = new OpTypeBoolNodeFactory();

        public OpTypeBoolNodeFactory():base(new ScriptNode()
        {
            Name = "TypeBool",
            Category = NodeCategory.Function,
            Type = "OpTypeBool",
            InputPins =
            {
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