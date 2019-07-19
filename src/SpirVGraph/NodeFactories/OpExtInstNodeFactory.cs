using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpExtInstNodeFactory : AbstractNodeFactory
    {
        public static readonly OpExtInstNodeFactory Instance = new OpExtInstNodeFactory();

        public OpExtInstNodeFactory():base(new ScriptNode()
        {
            Name = "ExtInst",
            Category = NodeCategory.Function,
            Type = "OpExtInst",
            InputPins =
            {
                new PinWithConnection("Set",null),
                new PinWithConnection("Operands",null),
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