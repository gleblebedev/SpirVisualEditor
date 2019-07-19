using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupSMinNonUniformAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupSMinNonUniformAMDNodeFactory Instance = new OpGroupSMinNonUniformAMDNodeFactory();

        public OpGroupSMinNonUniformAMDNodeFactory():base(new ScriptNode()
        {
            Name = "GroupSMinNonUniformAMD",
            Category = NodeCategory.Function,
            Type = "OpGroupSMinNonUniformAMD",
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