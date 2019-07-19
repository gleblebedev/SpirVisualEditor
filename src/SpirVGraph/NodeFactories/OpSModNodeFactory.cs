using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSModNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSModNodeFactory Instance = new OpSModNodeFactory();

        public OpSModNodeFactory():base(new ScriptNode()
        {
            Name = "SMod",
            Category = NodeCategory.Function,
            Type = "OpSMod",
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