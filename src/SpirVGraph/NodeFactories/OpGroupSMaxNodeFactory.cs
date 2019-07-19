using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupSMaxNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupSMaxNodeFactory Instance = new OpGroupSMaxNodeFactory();

        public OpGroupSMaxNodeFactory():base(new ScriptNode()
        {
            Name = "GroupSMax",
            Category = NodeCategory.Function,
            Type = "OpGroupSMax",
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