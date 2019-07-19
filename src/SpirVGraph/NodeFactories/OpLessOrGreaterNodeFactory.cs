using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpLessOrGreaterNodeFactory : AbstractNodeFactory
    {
        public static readonly OpLessOrGreaterNodeFactory Instance = new OpLessOrGreaterNodeFactory();

        public OpLessOrGreaterNodeFactory():base(new ScriptNode()
        {
            Name = "LessOrGreater",
            Category = NodeCategory.Function,
            Type = "OpLessOrGreater",
            InputPins =
            {
                new PinWithConnection("x",null),
                new PinWithConnection("y",null),
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