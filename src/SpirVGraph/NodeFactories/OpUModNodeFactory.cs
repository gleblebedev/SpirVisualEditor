using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpUModNodeFactory : AbstractNodeFactory
    {
        public static readonly OpUModNodeFactory Instance = new OpUModNodeFactory();

        public OpUModNodeFactory():base(new ScriptNode()
        {
            Name = "UMod",
            Category = NodeCategory.Function,
            Type = "OpUMod",
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