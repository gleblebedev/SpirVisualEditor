using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupFMaxNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupFMaxNodeFactory Instance = new OpGroupFMaxNodeFactory();

        public OpGroupFMaxNodeFactory():base(new ScriptNode()
        {
            Name = "GroupFMax",
            Category = NodeCategory.Function,
            Type = "OpGroupFMax",
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