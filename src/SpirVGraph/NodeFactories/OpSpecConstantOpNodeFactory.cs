using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSpecConstantOpNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSpecConstantOpNodeFactory Instance = new OpSpecConstantOpNodeFactory();

        public OpSpecConstantOpNodeFactory():base(new ScriptNode()
        {
            Name = "SpecConstantOp",
            Category = NodeCategory.Function,
            Type = "OpSpecConstantOp",
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