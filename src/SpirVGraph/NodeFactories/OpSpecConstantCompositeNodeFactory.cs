using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSpecConstantCompositeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSpecConstantCompositeNodeFactory Instance = new OpSpecConstantCompositeNodeFactory();

        public OpSpecConstantCompositeNodeFactory():base(new ScriptNode()
        {
            Name = "SpecConstantComposite",
            Category = NodeCategory.Function,
            Type = "OpSpecConstantComposite",
            InputPins =
            {
                new PinWithConnection("Constituents",null),
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