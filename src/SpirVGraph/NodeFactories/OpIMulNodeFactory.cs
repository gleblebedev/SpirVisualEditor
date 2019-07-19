using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIMulNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIMulNodeFactory Instance = new OpIMulNodeFactory();

        public OpIMulNodeFactory():base(new ScriptNode()
        {
            Name = "IMul",
            Category = NodeCategory.Function,
            Type = "OpIMul",
            InputPins =
            {
                new PinWithConnection("Operand1",null),
                new PinWithConnection("Operand2",null),
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