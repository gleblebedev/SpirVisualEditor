using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpOuterProductNodeFactory : AbstractNodeFactory
    {
        public static readonly OpOuterProductNodeFactory Instance = new OpOuterProductNodeFactory();

        public OpOuterProductNodeFactory():base(new ScriptNode()
        {
            Name = "OuterProduct",
            Category = NodeCategory.Function,
            Type = "OpOuterProduct",
            InputPins =
            {
                new PinWithConnection("Vector1",null),
                new PinWithConnection("Vector2",null),
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