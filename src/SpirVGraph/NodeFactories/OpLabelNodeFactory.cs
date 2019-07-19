using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLabelNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLabelNodeFactory Instance = new OpLabelNodeFactory();

        public OpLabelNodeFactory():base(new ScriptNode()
        {
            Name = "Label",
            Category = NodeCategory.Function,
            Type = "OpLabel",
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