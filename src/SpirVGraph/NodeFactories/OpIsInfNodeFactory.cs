using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpIsInfNodeFactory : AbstractNodeFactory
    {
        public static readonly OpIsInfNodeFactory Instance = new OpIsInfNodeFactory();

        public OpIsInfNodeFactory():base(new ScriptNode()
        {
            Name = "IsInf",
            Category = NodeCategory.Function,
            Type = "OpIsInf",
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