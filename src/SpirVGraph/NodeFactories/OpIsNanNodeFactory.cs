using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIsNanNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIsNanNodeFactory Instance = new OpIsNanNodeFactory();

        public OpIsNanNodeFactory():base(new ScriptNode()
        {
            Name = "IsNan",
            Category = NodeCategory.Function,
            Type = "OpIsNan",
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