using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBitcastNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBitcastNodeFactory Instance = new OpBitcastNodeFactory();

        public OpBitcastNodeFactory():base(new ScriptNode()
        {
            Name = "Bitcast",
            Category = NodeCategory.Function,
            Type = "OpBitcast",
            InputPins =
            {
                new PinWithConnection("Operand",null),
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