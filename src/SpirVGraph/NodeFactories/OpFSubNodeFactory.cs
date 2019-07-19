using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFSubNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFSubNodeFactory Instance = new OpFSubNodeFactory();

        public OpFSubNodeFactory():base(new ScriptNode()
        {
            Name = "FSub",
            Category = NodeCategory.Function,
            Type = "OpFSub",
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