using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTransposeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTransposeNodeFactory Instance = new OpTransposeNodeFactory();

        public OpTransposeNodeFactory():base(new ScriptNode()
        {
            Name = "Transpose",
            Category = NodeCategory.Function,
            Type = "OpTranspose",
            InputPins =
            {
                new PinWithConnection("Matrix",null),
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