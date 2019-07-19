using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupUMaxNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupUMaxNodeFactory Instance = new OpGroupUMaxNodeFactory();

        public OpGroupUMaxNodeFactory():base(new ScriptNode()
        {
            Name = "GroupUMax",
            Category = NodeCategory.Function,
            Type = "OpGroupUMax",
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