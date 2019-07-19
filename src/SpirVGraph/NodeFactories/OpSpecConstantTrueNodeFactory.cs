using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSpecConstantTrueNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSpecConstantTrueNodeFactory Instance = new OpSpecConstantTrueNodeFactory();

        public OpSpecConstantTrueNodeFactory():base(new ScriptNode()
        {
            Name = "SpecConstantTrue",
            Category = NodeCategory.Function,
            Type = "OpSpecConstantTrue",
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