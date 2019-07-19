using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeFloatNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeFloatNodeFactory Instance = new OpTypeFloatNodeFactory();

        public OpTypeFloatNodeFactory():base(new ScriptNode()
        {
            Name = "TypeFloat",
            Category = NodeCategory.Function,
            Type = "OpTypeFloat",
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