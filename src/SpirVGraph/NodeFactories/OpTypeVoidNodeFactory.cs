using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeVoidNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeVoidNodeFactory Instance = new OpTypeVoidNodeFactory();

        public OpTypeVoidNodeFactory():base(new ScriptNode()
        {
            Name = "TypeVoid",
            Category = NodeCategory.Function,
            Type = "OpTypeVoid",
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