using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupFMinNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupFMinNodeFactory Instance = new OpGroupFMinNodeFactory();

        public OpGroupFMinNodeFactory():base(new ScriptNode()
        {
            Name = "GroupFMin",
            Category = NodeCategory.Function,
            Type = "OpGroupFMin",
            InputPins =
            {
                new PinWithConnection("X",null),
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