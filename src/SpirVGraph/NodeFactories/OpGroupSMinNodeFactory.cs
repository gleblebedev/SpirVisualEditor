using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupSMinNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupSMinNodeFactory Instance = new OpGroupSMinNodeFactory();

        public OpGroupSMinNodeFactory():base(new ScriptNode()
        {
            Name = "GroupSMin",
            Category = NodeCategory.Function,
            Type = "OpGroupSMin",
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