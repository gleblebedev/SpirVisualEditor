using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeReserveIdNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeReserveIdNodeFactory Instance = new OpTypeReserveIdNodeFactory();

        public OpTypeReserveIdNodeFactory():base(new ScriptNode()
        {
            Name = "TypeReserveId",
            Category = NodeCategory.Function,
            Type = "OpTypeReserveId",
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