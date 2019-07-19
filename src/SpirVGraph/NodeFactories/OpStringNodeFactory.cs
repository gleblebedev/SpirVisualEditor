using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpStringNodeFactory : AbstractNodeFactory
    {
        public static readonly OpStringNodeFactory Instance = new OpStringNodeFactory();

        public OpStringNodeFactory():base(new ScriptNode()
        {
            Name = "String",
            Category = NodeCategory.Function,
            Type = "OpString",
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