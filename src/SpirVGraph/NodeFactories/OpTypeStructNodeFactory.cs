using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeStructNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeStructNodeFactory Instance = new OpTypeStructNodeFactory();

        public OpTypeStructNodeFactory():base(new ScriptNode()
        {
            Name = "TypeStruct",
            Category = NodeCategory.Function,
            Type = "OpTypeStruct",
            InputPins =
            {
                new PinWithConnection("MemberTypes",null),
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