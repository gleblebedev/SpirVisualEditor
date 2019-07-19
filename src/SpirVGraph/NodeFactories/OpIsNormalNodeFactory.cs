using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIsNormalNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIsNormalNodeFactory Instance = new OpIsNormalNodeFactory();

        public OpIsNormalNodeFactory():base(new ScriptNode()
        {
            Name = "IsNormal",
            Category = NodeCategory.Function,
            Type = "OpIsNormal",
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