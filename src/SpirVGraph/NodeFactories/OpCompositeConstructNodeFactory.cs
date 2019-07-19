using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCompositeConstructNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCompositeConstructNodeFactory Instance = new OpCompositeConstructNodeFactory();

        public OpCompositeConstructNodeFactory():base(new ScriptNode()
        {
            Name = "CompositeConstruct",
            Category = NodeCategory.Function,
            Type = "OpCompositeConstruct",
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