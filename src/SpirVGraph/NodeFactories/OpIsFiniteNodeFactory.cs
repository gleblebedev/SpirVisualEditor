using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIsFiniteNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIsFiniteNodeFactory Instance = new OpIsFiniteNodeFactory();

        public OpIsFiniteNodeFactory():base(new ScriptNode()
        {
            Name = "IsFinite",
            Category = NodeCategory.Function,
            Type = "OpIsFinite",
            InputPins =
            {
                new PinWithConnection("x",null),
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