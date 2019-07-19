using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFModNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFModNodeFactory Instance = new OpFModNodeFactory();

        public OpFModNodeFactory():base(new ScriptNode()
        {
            Name = "FMod",
            Category = NodeCategory.Function,
            Type = "OpFMod",
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