using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSpecConstantNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSpecConstantNodeFactory Instance = new OpSpecConstantNodeFactory();

        public OpSpecConstantNodeFactory():base(new ScriptNode()
        {
            Name = "SpecConstant",
            Category = NodeCategory.Function,
            Type = "OpSpecConstant",
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