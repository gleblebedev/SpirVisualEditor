using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupMemberDecorateNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupMemberDecorateNodeFactory Instance = new OpGroupMemberDecorateNodeFactory();

        public OpGroupMemberDecorateNodeFactory():base(new ScriptNode()
        {
            Name = "GroupMemberDecorate",
            Category = NodeCategory.Function,
            Type = "OpGroupMemberDecorate",
            InputPins =
            {
                new PinWithConnection("DecorationGroup",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}