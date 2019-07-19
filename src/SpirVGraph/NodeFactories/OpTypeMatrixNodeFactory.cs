using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeMatrixNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeMatrixNodeFactory Instance = new OpTypeMatrixNodeFactory();

        public OpTypeMatrixNodeFactory():base(new ScriptNode()
        {
            Name = "TypeMatrix",
            Category = NodeCategory.Function,
            Type = "OpTypeMatrix",
            InputPins =
            {
                new PinWithConnection("ColumnType",null),
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