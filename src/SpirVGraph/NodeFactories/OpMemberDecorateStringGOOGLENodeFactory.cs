using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpMemberDecorateStringGOOGLENodeFactory : AbstractNodeFactory
    {
        public static readonly OpMemberDecorateStringGOOGLENodeFactory Instance = new OpMemberDecorateStringGOOGLENodeFactory();

        public OpMemberDecorateStringGOOGLENodeFactory():base(new ScriptNode()
        {
            Name = "MemberDecorateStringGOOGLE",
            Category = NodeCategory.Function,
            Type = "OpMemberDecorateStringGOOGLE",
            InputPins =
            {
                new PinWithConnection("StructType",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}