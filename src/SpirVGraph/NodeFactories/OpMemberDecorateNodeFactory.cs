using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpMemberDecorateNodeFactory : AbstractNodeFactory
    {
        public static readonly OpMemberDecorateNodeFactory Instance = new OpMemberDecorateNodeFactory();

        public OpMemberDecorateNodeFactory():base(new ScriptNode()
        {
            Name = "MemberDecorate",
            Category = NodeCategory.Function,
            Type = "OpMemberDecorate",
            InputPins =
            {
                new PinWithConnection("StructureType",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}