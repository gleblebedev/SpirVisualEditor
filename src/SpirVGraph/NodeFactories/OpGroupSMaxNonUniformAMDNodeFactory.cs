using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupSMaxNonUniformAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupSMaxNonUniformAMDNodeFactory Instance = new OpGroupSMaxNonUniformAMDNodeFactory();

        public OpGroupSMaxNonUniformAMDNodeFactory():base(new ScriptNode()
        {
            Name = "GroupSMaxNonUniformAMD",
            Category = NodeCategory.Function,
            Type = "OpGroupSMaxNonUniformAMD",
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