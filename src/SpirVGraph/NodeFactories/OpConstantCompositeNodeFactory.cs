using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConstantCompositeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConstantCompositeNodeFactory Instance = new OpConstantCompositeNodeFactory();

        public OpConstantCompositeNodeFactory():base(new ScriptNode()
        {
            Name = "ConstantComposite",
            Category = NodeCategory.Function,
            Type = "OpConstantComposite",
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