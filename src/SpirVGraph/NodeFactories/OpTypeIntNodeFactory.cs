using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeIntNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeIntNodeFactory Instance = new OpTypeIntNodeFactory();

        public OpTypeIntNodeFactory():base(new ScriptNode()
        {
            Name = "TypeInt",
            Category = NodeCategory.Function,
            Type = "OpTypeInt",
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