using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpDecorationGroupNodeFactory : AbstractNodeFactory
    {
        public static readonly OpDecorationGroupNodeFactory Instance = new OpDecorationGroupNodeFactory();

        public OpDecorationGroupNodeFactory():base(new ScriptNode()
        {
            Name = "DecorationGroup",
            Category = NodeCategory.Function,
            Type = "OpDecorationGroup",
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