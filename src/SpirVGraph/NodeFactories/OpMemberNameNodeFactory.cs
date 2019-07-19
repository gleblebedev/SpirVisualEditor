using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpMemberNameNodeFactory : AbstractNodeFactory
    {
        public static readonly OpMemberNameNodeFactory Instance = new OpMemberNameNodeFactory();

        public OpMemberNameNodeFactory():base(new ScriptNode()
        {
            Name = "MemberName",
            Category = NodeCategory.Function,
            Type = "OpMemberName",
            InputPins =
            {
                new PinWithConnection("Type",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}